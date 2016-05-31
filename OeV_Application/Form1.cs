using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Net;

namespace OeV_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BuildComponent();

            ErrorExceptions = new List<string>();
            ErrorTargets = new List<object>();

            //Set Ab / An
            button_Departure.Enabled = false;
        }

        public DateTime TravelDateTime { get; set; }

        public List<Connection> Connections { get; set; }

        public StationBoardRoot stationboardroot { get; set; }

        public Station Fromstation { get; set; }

        public Station ToStation { get; set; }

        public List<string> ErrorExceptions { get; set; }

        public List<object> ErrorTargets { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            TravelDateTime = DateTimePicker.Value;

            //Are Data Valid
            if (ValidatorConnection())
            {
                ConnectionsLoadFunction connectionsLoader = new ConnectionsLoadFunction();

                //Read text out of Combobox and checkbox
                string FromSearchText = CmbFrom.SelectedItem != null ? CmbFrom.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbFrom.Text) ? CmbFrom.Text : string.Empty;
                string ToSearchText = CmbTo.SelectedItem != null ? CmbTo.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbTo.Text) ? CmbTo.Text : string.Empty;
                //1. SelectedItem
                //2. Text

                //Set DateTime
                DateTime dt;
                if (!string.IsNullOrEmpty(txb_Time.Text))
                {
                    dt = DateTime.Parse(txb_Time.Text);
                }
                else
                {
                    dt = DateTime.Now;
                }

                //Load Connections
                Connections = connectionsLoader.Execute(FromSearchText, ToSearchText, new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, dt.Hour, dt.Minute, 0), !button_Arrive.Enabled);

                //Any Connections
                if (Connections.Any())
                {
                    //Clear all Listview Items
                    listView1.Items.Clear();
                    foreach (Connection connection in Connections)
                    {
                        //Write Connection into the Listview
                        DateTime depa = DateTime.Parse(connection.From.Departure);
                        DateTime arriv = DateTime.Parse(connection.To.Arrival);

                        TimeSpan duration = TimeSpan.ParseExact(connection.Duration, "dd'd'hh':'mm':'ss", null);

                        ListViewItem listviewitem = new ListViewItem(connection.From.Station.Name);
                        listviewitem.SubItems.Add(connection.To.Station.Name);
                        listviewitem.SubItems.Add(depa.ToString("HH:mm"));
                        listviewitem.SubItems.Add(arriv.ToString("HH:mm"));
                        listviewitem.SubItems.Add(duration.ToString(@"hh\:mm"));

                        listView1.Items.Add(listviewitem);
                    }
                }
                else
                {
                    MessageBox.Show("Es wurden keine Verbindungen zu Ihrer Suche gefunden.");
                }
            }
            else
            {
                CreateDialogWindow();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidatorStationBoard())
            {
                DateTime dt;
                if (!string.IsNullOrEmpty(textbox_Time_Stationboard.Text))
                {
                    dt = DateTime.Parse(textbox_Time_Stationboard.Text);
                }
                else
                {
                    dt = DateTime.Now;
                }

                //Load Stationboard
                stationboardroot = LoadStationBoard(cmbBoardName.SelectedItem != null ? cmbBoardName.SelectedItem.ToString() : !string.IsNullOrEmpty(cmbBoardName.Text) ? cmbBoardName.Text : string.Empty, new DateTime(Date_Stationboard.Value.Year, Date_Stationboard.Value.Month, Date_Stationboard.Value.Day, dt.Hour, dt.Minute, 0));

                //Clear Stationboard listview
                stationBoardListView.Items.Clear();

                foreach (StationBoard stationboard in stationboardroot.Entries)
                {
                    // wirte stationboard into the listview
                    ListViewItem listViewItem = new ListViewItem(stationboardroot.Station.Name);
                    listViewItem.SubItems.Add(stationboard.To);
                    listViewItem.SubItems.Add(stationboard.Stop.Departure.ToString("HH:mm"));
                    listViewItem.SubItems.Add(stationboard.Category);
                    listViewItem.SubItems.Add(stationboard.Operator);
                    stationBoardListView.Items.Add(listViewItem);
                }
            }
            else
            {
                CreateDialogWindow();
            }
        }

        private void CmbFrom_TextChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
            {
                //Reload Items into Checkbox
                LoadRequestResultToCombobox(cmb);
            }
        }

        private void CmbTo_TextChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
            {
                //reload Combobox Items 
                LoadRequestResultToCombobox(cmb);
            }
        }

        private void cmbBoardName_TextChanged(object sender, EventArgs e)
        {
            //reload Combobox Items 
            ComboBox cmb = (ComboBox)sender;
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
            {
                LoadRequestResultToCombobox(cmb);
            }
        }

        private void CmbFrom_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    CmbFrom.DroppedDown = true;
                    break;
                case Keys.Enter:
                    LoadRequestResultToCombobox(CmbFrom, true);
                    break;
                default:
                    break;
            }
        }

        private void CmdTo_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    CmbTo.DroppedDown = true;
                    break;
                case Keys.Enter:
                    LoadRequestResultToCombobox(CmbFrom, true);
                    break;
                default:
                    break;
            }
        }

        private void cmbBoardName_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    cmbBoardName.DroppedDown = true;
                    break;
                case Keys.Enter:
                    LoadRequestResultToCombobox(cmbBoardName, true);
                    break;
                default:
                    break;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //Open Mailsend view
            MailSendForm form = new MailSendForm(listView1.SelectedItems[0]);
            form.Show();
        }

        private void Button_Arrive_Click(object sender, EventArgs e)
        {
            //Change An / Ab
            button_Arrive.Enabled = false;
            button_Departure.Enabled = true;
        }

        private void button_Departure_Click(object sender, EventArgs e)
        {
            //Change An / Ab
            button_Departure.Enabled = false;
            button_Arrive.Enabled = true;
        }

        private void Button_MapFrom_Click(object sender, EventArgs e)
        {
            //Load Map view
            StationsLoadFunction stationsloadfunction = new StationsLoadFunction();
            List<Station> stations = stationsloadfunction.Execute(CmbFrom.Text);

            if (stations != null && stations.Any())
            {
                MapsForm mapsform = new MapsForm(stations);
                mapsform.Show();
            }
            else
            {
                MessageBox.Show("Es konnten keine Stationen gefunden werden.");
            }

        }

        private void button_MapTo_Click(object sender, EventArgs e)
        {
            //Load Map view
            StationsLoadFunction stationsloadfunction = new StationsLoadFunction();
            List<Station> stations = stationsloadfunction.Execute(CmbTo.Text);

            if (stations != null && stations.Any())
            {
                MapsForm mapsform = new MapsForm(stations);
                mapsform.Show();
            }
            else
            {
                MessageBox.Show("Es konnten keine Stationen gefunden werden.");
            }
        }

        private bool ValidatorConnection()
        {
            //Reset Color
            ResetColor();

            //Clear Exceptions
            ErrorExceptions.Clear();
            ErrorTargets.Clear();

            //Load values from Control
            string FromStationText = CmbFrom.Text;
            string ToStationText = CmbTo.Text;
            string Time = txb_Time.Text;

            if (string.IsNullOrEmpty(FromStationText))
            {
                ErrorExceptions.Add("Die Suche nach der Abfahrtsstation darf nicht leer sein.");
                ErrorTargets.Add(CmbFrom);
            }
            else if (FromStationText.Length > 100)
            {
                ErrorExceptions.Add("Die Suche nach der Abfahrtsstation darf maximal 100 Zeichen lang sein.");
                ErrorTargets.Add(CmbFrom);
            }
            else if (CmbFrom.SelectedItem == null)
            {
                if (CmbFrom.Items.IndexOf(CmbFrom.Text) == -1)
                {
                    ErrorExceptions.Add("Bitte wählen sie ein Element aus der Auswahl für die Abfahrtsstation aus.");
                    ErrorTargets.Add(CmbFrom);
                }
            }

            if (string.IsNullOrEmpty(ToStationText))
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf nicht leer sein.");
                ErrorTargets.Add(CmbTo);
            }
            else if (ToStationText.Length > 100)
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf maximal 100 Zeichen lang sein.");
                ErrorTargets.Add(CmbTo);
            }
            else if (CmbTo.SelectedItem == null)
            {
                if (CmbTo.Items.IndexOf(CmbTo.Text) == -1)
                {
                    ErrorExceptions.Add("Bitte wählen sie ein Element aus der Auswahl für die Ankunftsstation aus.");
                    ErrorTargets.Add(CmbTo);
                }
            }

            DateTime output;

            if (Time.Length > 5)
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:MM");
                ErrorTargets.Add(txb_Time);
            }
            //Check has Time the right format
            else if (!DateTime.TryParseExact(Time, "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None , out output))
            { 
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:mm");
                ErrorTargets.Add(txb_Time);
            }
            //Any Exceptions?
            if (ErrorExceptions.Any())
            {
                //Set Color Red
                SetColorRed();
                return false;
            }

            return true;
        }

        private bool ValidatorStationBoard()
        {
            //Reset Color
            ResetColor();

            //Clear Exceptions
            ErrorExceptions.Clear();
            ErrorTargets.Clear();

            string FromStationText = cmbBoardName.Text;
            string Time = textbox_Time_Stationboard.Text;

            DateTime output;

            if (Time.Length > 5)
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:MM");
                ErrorTargets.Add(textbox_Time_Stationboard);
            }
            //Check has Time the right format
            else if (!DateTime.TryParseExact(Time, "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out output))
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:mm");
                ErrorTargets.Add(textbox_Time_Stationboard);
            }

            if (string.IsNullOrEmpty(FromStationText))
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf nicht leer sein.");
                ErrorTargets.Add(cmbBoardName);
            }
            else if (FromStationText.Length > 100)
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf maximal 100 Zeichen lang sein.");
                ErrorTargets.Add(cmbBoardName);
            }
            else if (cmbBoardName.SelectedItem == null)
            {
                if (cmbBoardName.Items.IndexOf(cmbBoardName.Text) == -1)
                {
                    ErrorExceptions.Add("Bitte wählen sie ein Element aus der Auswahl für die Ankunftsstation aus.");
                    ErrorTargets.Add(cmbBoardName);
                }
            }

            //Any Exceptions?
            if (ErrorExceptions.Any())
            {
                //Set Color Red
                SetColorRed();
                return false;
            }

            return true;
        }

        private void BuildComponent()
        {
            // Build header from the listview
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Abfahrts Station");
            listView1.Columns.Add("Ankunfts Station");
            listView1.Columns.Add("Abfahrt");
            listView1.Columns.Add("Ankunft");
            listView1.Columns.Add("Dauer");
            listView1.Columns.Add("Umsteigen");

            // Build header from the listview
            stationBoardListView.View = View.Details;
            stationBoardListView.FullRowSelect = true;
            stationBoardListView.Columns.Add("Abfahrts Station");
            stationBoardListView.Columns.Add("Ankunfts Station");
            stationBoardListView.Columns.Add("Abfahrt");
            stationBoardListView.Columns.Add("Kategorie");
            stationBoardListView.Columns.Add("Anbieter");

            //Write Datetime.Now into the Time Textbox
            textbox_Time_Stationboard.Text = DateTime.Now.ToString("HH:mm");
            txb_Time.Text = DateTime.Now.ToString("HH:mm");
        }

        private void LoadRequestResultToCombobox(ComboBox cmb, bool executeRequest = false)
        {
            int cursorpos = cmb.SelectionStart;
            //Disable view
            this.Enabled = false;

            //Load Stations
            StationsLoadFunction stationLoadFunction = new StationsLoadFunction();
            List<Station> stationlist = stationLoadFunction.Execute(cmb.Text);

            //Clear Combobox Items
            cmb.Items.Clear();
            foreach (Station station in stationlist)
            {
                // Add name to Combobox item
                cmb.Items.Add(station.Name);
            }

            //reactivate view
            this.Enabled = true;
            cmb.SelectionStart = cursorpos;
        }

        private StationBoardRoot LoadStationBoard(string name, DateTime date)
        {
            // Load Stationboard
            Transport transportConnection = new Transport();

            return transportConnection.GetStationBoardWithSpecificTime(name, date);
            //return transportConnection.GetStationBoard(name);
        }

        private void SetColorRed()
        {
            //Set ColorRed by the Contorls, where exist a error
            foreach (object target in ErrorTargets)
            {
                if (target.GetType() == typeof(TextBox))
                {
                    TextBox textbox = (TextBox)target;
                    textbox.BackColor = Color.Red;
                }
                else if (target.GetType() == typeof(RichTextBox))
                {
                    RichTextBox richtextbox = (RichTextBox)target;
                    richtextbox.BackColor = Color.Red;
                }
                else if (target.GetType() == typeof(ComboBox))
                {
                    ComboBox combobox = (ComboBox)target;
                    combobox.BackColor = Color.Red;
                }
            }
        }

        private void ResetColor()
        {
            //Reset all Colors from the Controls
            foreach (Control control in this.Controls[0].Controls)
            {
                foreach(Control Childcontrol in control.Controls)
                {
                    if (Childcontrol.GetType() == typeof(TextBox))
                    {
                        TextBox textbox = (TextBox)Childcontrol;
                        textbox.BackColor = SystemColors.Window;
                    }
                    else if (Childcontrol.GetType() == typeof(RichTextBox))
                    {
                        RichTextBox richtextbox = (RichTextBox)Childcontrol;
                        richtextbox.BackColor = SystemColors.Window;
                    }
                    else if (Childcontrol.GetType() == typeof(ComboBox))
                    {
                        ComboBox combobox = (ComboBox)Childcontrol;
                        combobox.BackColor = SystemColors.Window;
                    }
                }
                    
            }
        }

        private void CreateDialogWindow()
        {
            //Create Messagebox with Error Messages
            string DialogResultString = string.Empty;

            foreach (string error in ErrorExceptions)
            {
                DialogResultString += error + "\n\n";
            }

            MessageBox.Show(DialogResultString);
        }
    }
}
