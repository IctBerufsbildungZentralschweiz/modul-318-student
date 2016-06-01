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
    public partial class OeV_Application : Form
    {
        public OeV_Application()
        {
            InitializeComponent();
            BuildComponent();

            ErrorExceptions = new List<string>();
            ErrorTargets = new List<object>();

            //Set Ab / An
            Button_Departure.Enabled = false;
        }

        public DateTime TravelDateTime { get; set; }

        public List<Connection> Connections { get; set; }

        public StationBoardRoot stationboardroot { get; set; }

        public Station Fromstation { get; set; }

        public Station ToStation { get; set; }

        public List<string> ErrorExceptions { get; set; }

        public List<object> ErrorTargets { get; set; }

        private void Button_Connection_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            TravelDateTime = DateTimeConnection.Value;

            //Are Data Valid
            if (ValidatorConnection())
            {
                ConnectionsLoadFunction connectionsLoader = new ConnectionsLoadFunction();

                //Read text out of Combobox and checkbox
                string FromSearchText = CmbFrom_ConnectionSearch.SelectedItem != null ? CmbFrom_ConnectionSearch.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbFrom_ConnectionSearch.Text) ? CmbFrom_ConnectionSearch.Text : string.Empty;
                string ToSearchText = CmbTo_ConnectionSearch.SelectedItem != null ? CmbTo_ConnectionSearch.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbTo_ConnectionSearch.Text) ? CmbTo_ConnectionSearch.Text : string.Empty;
                //1. SelectedItem
                //2. Text

                //Set DateTime
                DateTime dt;
                if (!string.IsNullOrEmpty(Txb_TimeConnection.Text))
                {
                    dt = DateTime.Parse(Txb_TimeConnection.Text);
                }
                else
                {
                    dt = DateTime.Now;
                }

                //Load Connections
                Connections = connectionsLoader.Execute(FromSearchText, ToSearchText, new DateTime(DateTimeConnection.Value.Year, DateTimeConnection.Value.Month, DateTimeConnection.Value.Day, dt.Hour, dt.Minute, 0), !Button_Arrive.Enabled);

                //Any Connections
                if (Connections.Any())
                {

                    //Clear all Listview Items
                    ConnectionsListView.Items.Clear();
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

                        ConnectionsListView.Items.Add(listviewitem);
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

            Cursor = Cursors.Default;
        }

        private void Button_Stationboard_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (ValidatorStationBoard())
            {
                DateTime dt;
                if (!string.IsNullOrEmpty(Txb_TimeStationboard.Text))
                {
                    dt = DateTime.Parse(Txb_TimeStationboard.Text);
                }
                else
                {
                    dt = DateTime.Now;
                }

                //Load Stationboard
                stationboardroot = LoadStationBoard(CmbFrom_StationBoard.SelectedItem != null ? CmbFrom_StationBoard.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbFrom_StationBoard.Text) ? CmbFrom_StationBoard.Text : string.Empty, new DateTime(DateTimeStationBoard.Value.Year, DateTimeStationBoard.Value.Month, DateTimeStationBoard.Value.Day, dt.Hour, dt.Minute, 0));

                if (stationboardroot.Entries.Any())
                {
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
                    MessageBox.Show("Es wurde kein Abfahrtsplan zu Ihrer Suche gefunden.");
                }

            }
            else
            {
                CreateDialogWindow();
            }

            Cursor = Cursors.Default;
        }

        #region OldEventHandler
        //private void CmbFrom_TextChanged(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;

        //    ComboBox cmb = (ComboBox)sender;
        //    if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
        //    {
        //        //Reload Items into Checkbox
        //        LoadRequestResultToCombobox(cmb);
        //    }

        //    Cursor = Cursors.Default;
        //}

        //private void CmbTo_TextChanged(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;

        //    ComboBox cmb = (ComboBox)sender;
        //    if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
        //    {
        //        //reload Combobox Items 
        //        LoadRequestResultToCombobox(cmb);
        //    }

        //    Cursor = Cursors.Default;
        //}

        //private void cmbBoardName_TextChanged(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;

        //    //reload Combobox Items 
        //    ComboBox cmb = (ComboBox)sender;
        //    if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
        //    {
        //        LoadRequestResultToCombobox(cmb);
        //    }

        //    Cursor = Cursors.Default;
        //}

        //private void CmbFrom_KeyPress(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Down:
        //            CmbFrom.DroppedDown = true;
        //            break;
        //        case Keys.Enter:
        //            LoadRequestResultToCombobox(CmbFrom, true);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void CmdTo_KeyPress(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Down:
        //            CmbTo.DroppedDown = true;
        //            break;
        //        case Keys.Enter:
        //            LoadRequestResultToCombobox(CmbFrom, true);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void cmbBoardName_KeyPress(object sender, KeyEventArgs e)
        //{
        //    switch (e.KeyCode)
        //    {
        //        case Keys.Down:
        //            cmbBoardName.DroppedDown = true;
        //            break;
        //        case Keys.Enter:
        //            LoadRequestResultToCombobox(cmbBoardName, true);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void Button_Arrive_Click(object sender, EventArgs e)
        //{
        //    //Change An / Ab
        //    button_Arrive.Enabled = false;
        //    button_Departure.Enabled = true;
        //}

        //private void button_Departure_Click(object sender, EventArgs e)
        //{
        //    //Change An / Ab
        //    button_Departure.Enabled = false;
        //    button_Arrive.Enabled = true;
        //}


        //private void Button_MapFrom_Click(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;

        //    //Load Map view
        //    StationsLoadFunction stationsloadfunction = new StationsLoadFunction();
        //    List<Station> stations = stationsloadfunction.Execute(CmbFrom.Text);

        //    if (stations != null && stations.Any())
        //    {
        //        MapsForm mapsform = new MapsForm(stations);
        //        mapsform.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Es konnten keine Stationen gefunden werden.");
        //    }

        //    Cursor = Cursors.Default;
        //}

        //private void button_MapTo_Click(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;

        //    //Load Map view
        //    StationsLoadFunction stationsloadfunction = new StationsLoadFunction();
        //    List<Station> stations = stationsloadfunction.Execute(CmbTo.Text);

        //    if (stations != null && stations.Any())
        //    {
        //        MapsForm mapsform = new MapsForm(stations);
        //        mapsform.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Es konnten keine Stationen gefunden werden.");
        //    }

        //    Cursor = Cursors.Default;
        //}

        #endregion

        private void Combobox_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            //reload Combobox Items 
            ComboBox cmb = (ComboBox)sender;
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
            {
                LoadRequestResultToCombobox(cmb);
            }

            Cursor = Cursors.Default;
        }

        private void Combobox_KeyPress(object sender, KeyEventArgs e)
        {
            ComboBox combobox = (ComboBox)sender;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    combobox.DroppedDown = true;
                    break;
                case Keys.Enter:
                    LoadRequestResultToCombobox(combobox, true);
                    break;
                default:
                    break;
            }
        }

        private void ListViewItem_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            ListView listview = (ListView)sender;

            //Open Mailsend view
            MailSendForm form = new MailSendForm(listview.SelectedItems[0], listview.Name);
            form.Show();

            Cursor = Cursors.Default;
        }

        private void Button_Departure_Arrival_Click(object sender, EventArgs e)
        {
            //Change An / Ab
            Button ClickedButton = (Button)sender;

            ClickedButton.Enabled = false;

            //unschöner Code 
            if (ClickedButton.Text == "An")
            {
                Button_Departure.Enabled = true;
            }
            else
            {
                Button_Arrive.Enabled = true;
            }
        }

        private void ButtonMap_Clicked(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string searchtext;

            Button ClickedButton = (Button)sender;

            //unschöner Code 
            if (ClickedButton.Name == "button_MapTo")
            {
                searchtext = CmbTo_ConnectionSearch.Text;
            }
            else
            {
                searchtext = CmbFrom_ConnectionSearch.Text;
            }

            //Load Map view
            StationsLoadFunction stationsloadfunction = new StationsLoadFunction();
            List<Station> stations = stationsloadfunction.Execute(searchtext);

            if (stations != null && stations.Any())
            {
                MapsForm mapsform = new MapsForm(stations);
                mapsform.Show();
            }
            else
            {
                MessageBox.Show("Es konnten keine Stationen gefunden werden.");
            }

            Cursor = Cursors.Default;
        }

        private bool ValidatorConnection()
        {
            //Reset Color
            ResetColor();

            //Clear Exceptions
            ErrorExceptions.Clear();
            ErrorTargets.Clear();

            //Load values from Control
            string FromStationText = CmbFrom_ConnectionSearch.Text;
            string ToStationText = CmbTo_ConnectionSearch.Text;
            string Time = Txb_TimeConnection.Text;

            if (string.IsNullOrEmpty(FromStationText))
            {
                ErrorExceptions.Add("Die Suche nach der Abfahrtsstation darf nicht leer sein.");
                ErrorTargets.Add(CmbFrom_ConnectionSearch);
            }
            else if (FromStationText.Length > 100)
            {
                ErrorExceptions.Add("Die Suche nach der Abfahrtsstation darf maximal 100 Zeichen lang sein.");
                ErrorTargets.Add(CmbFrom_ConnectionSearch);
            }
            else if (CmbFrom_ConnectionSearch.SelectedItem == null)
            {
                if (CmbFrom_ConnectionSearch.Items.IndexOf(CmbFrom_ConnectionSearch.Text) == -1)
                {
                    ErrorExceptions.Add("Bitte wählen sie ein Element aus der Auswahl für die Abfahrtsstation aus.");
                    ErrorTargets.Add(CmbFrom_ConnectionSearch);
                }
            }

            if (string.IsNullOrEmpty(ToStationText))
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf nicht leer sein.");
                ErrorTargets.Add(CmbTo_ConnectionSearch);
            }
            else if (ToStationText.Length > 100)
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf maximal 100 Zeichen lang sein.");
                ErrorTargets.Add(CmbTo_ConnectionSearch);
            }
            else if (CmbTo_ConnectionSearch.SelectedItem == null)
            {
                if (CmbTo_ConnectionSearch.Items.IndexOf(CmbTo_ConnectionSearch.Text) == -1)
                {
                    ErrorExceptions.Add("Bitte wählen sie ein Element aus der Auswahl für die Ankunftsstation aus.");
                    ErrorTargets.Add(CmbTo_ConnectionSearch);
                }
            }

            DateTime output;

            if (Time.Length > 5)
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:MM");
                ErrorTargets.Add(Txb_TimeConnection);
            }
            //Check has Time the right format
            else if (!DateTime.TryParseExact(Time, "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out output) && !string.IsNullOrEmpty(Time))
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:mm");
                ErrorTargets.Add(Txb_TimeConnection);
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

            string FromStationText = CmbFrom_StationBoard.Text;
            string Time = Txb_TimeStationboard.Text;

            DateTime output;

            if (Time.Length > 5)
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:MM");
                ErrorTargets.Add(Txb_TimeStationboard);
            }
            //Check has Time the right format
            else if (!DateTime.TryParseExact(Time, "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out output) && !string.IsNullOrEmpty(Time))
            {
                ErrorExceptions.Add("Die Uhrzeit eingabe entspricht nicht dem vorgegebenen Format. Format HH:mm");
                ErrorTargets.Add(Txb_TimeStationboard);
            }

            if (string.IsNullOrEmpty(FromStationText))
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf nicht leer sein.");
                ErrorTargets.Add(CmbFrom_StationBoard);
            }
            else if (FromStationText.Length > 100)
            {
                ErrorExceptions.Add("Die Suche nach der Ankunftsstation darf maximal 100 Zeichen lang sein.");
                ErrorTargets.Add(CmbFrom_StationBoard);
            }
            else if (CmbFrom_StationBoard.SelectedItem == null)
            {
                if (CmbFrom_StationBoard.Items.IndexOf(CmbFrom_StationBoard.Text) == -1)
                {
                    ErrorExceptions.Add("Bitte wählen sie ein Element aus der Auswahl für die Ankunftsstation aus.");
                    ErrorTargets.Add(CmbFrom_StationBoard);
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
            ConnectionsListView.View = View.Details;
            ConnectionsListView.FullRowSelect = true;
            ConnectionsListView.Columns.Add("Abfahrts Station");
            ConnectionsListView.Columns.Add("Ankunfts Station");
            ConnectionsListView.Columns.Add("Abfahrt");
            ConnectionsListView.Columns.Add("Ankunft");
            ConnectionsListView.Columns.Add("Dauer");
            ConnectionsListView.Columns.Add("not implement");

            ListViewWidthHeader(ConnectionsListView);


            // Build header from the listview
            stationBoardListView.View = View.Details;
            stationBoardListView.FullRowSelect = true;
            stationBoardListView.Columns.Add("Abfahrts Station");
            stationBoardListView.Columns.Add("Ankunfts Station");
            stationBoardListView.Columns.Add("Abfahrt");
            stationBoardListView.Columns.Add("Kategorie");
            stationBoardListView.Columns.Add("Anbieter");

            ListViewWidthHeader(stationBoardListView);

            //Write Datetime.Now into the Time Textbox
            Txb_TimeStationboard.Text = DateTime.Now.ToString("HH:mm");
            Txb_TimeConnection.Text = DateTime.Now.ToString("HH:mm");
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

            return transportConnection.GetStationBoardWithSpecificTime(name, date, "Es ist ein Problem beim Laden der Abfahrtstafel aufgetreten. Bitee überprüfen sie, dass sie eine Verbindung zur API : transport.opendata.ch haben." +
                        "\n\n Sollten sie  Problemem mit den Verbindung haben, so probieren sie die Anfrage bitte nochmals zu einem anderen Zeitpunkt. Ist mit Ihrer Verbindung alles in Ordnung. So führen sie die Aktion nochmals aus.");
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
                foreach (Control Childcontrol in control.Controls)
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

        private void ListViewWidthHeader(ListView listviewsource)
        {
            foreach (ColumnHeader column in listviewsource.Columns)
            {
                column.Width = -2;
            }
        }
    }
}
