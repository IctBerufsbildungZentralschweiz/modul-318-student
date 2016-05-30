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
        DateTime TravelDateTime;
        List<Connection> Connections;
        StationBoardRoot stationboardroot;
        Station Fromstation;
        Station ToStation; 

        public Form1()
        {
            InitializeComponent();
            BuildComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TravelDateTime = DateTimePicker.Value;

            if (Validator())
            {
                ConnectionsLoadFunction connectionsLoader = new ConnectionsLoadFunction();

                string FromSearchText = CmbFrom.SelectedItem != null ? CmbFrom.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbFrom.Text) ? CmbFrom.Text : string.Empty;
                string ToSearchText = CmbTo.SelectedItem != null ? CmbTo.SelectedItem.ToString() : !string.IsNullOrEmpty(CmbTo.Text) ? CmbTo.Text : string.Empty;

                DateTime dt = DateTime.Parse(txb_Time.Text);

                Connections = connectionsLoader.Execute(FromSearchText, ToSearchText, new DateTime(DateTimePicker.Value.Year, DateTimePicker.Value.Month, DateTimePicker.Value.Day, dt.Hour, dt.Minute, 0), !button_Arrive.Enabled);

                if (Connections.Any())
                {
                    listView1.Items.Clear();
                    foreach (Connection connection in Connections)
                    {
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
                MessageBox.Show("Eingaben sind nicht Valid.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stationboardroot = LoadStationBoard(cmbBoardName.SelectedItem != null ? cmbBoardName.SelectedItem.ToString() : !string.IsNullOrEmpty(cmbBoardName.Text) ? cmbBoardName.Text : string.Empty);

            stationBoardListView.Items.Clear();

            foreach (StationBoard stationboard in stationboardroot.Entries)
            {
               
                ListViewItem listViewItem = new ListViewItem(stationboardroot.Station.Name);
                listViewItem.SubItems.Add(stationboard.To);
                listViewItem.SubItems.Add(stationboard.Stop.Departure.ToString("HH:mm"));
                listViewItem.SubItems.Add(stationboard.Category);
                listViewItem.SubItems.Add(stationboard.Operator);
                stationBoardListView.Items.Add(listViewItem);
            }
        }

        private void CmbFrom_TextChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
            {
                LoadRequestResultToCombobox(cmb);
            }
        }

        private void CmbTo_TextChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null)
            {
                LoadRequestResultToCombobox(cmb);
            }
        }

        private void cmbBoardName_TextChanged(object sender, EventArgs e)
        {
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

        private bool Validator()
        {
            bool NoError = true;
            string FromStationText = CmbFrom.Text;
            string ToStationText = CmbTo.Text;

            if (FromStationText.Length > 100)
            {
                if (CmbFrom.BackColor == SystemColors.Window)
                {
                    SetErrorColor(CmbFrom, "Maximal 100 Zeichen erlaubt.");
                    NoError = false;
                }
            }
            else
            {
                if (CmbFrom.BackColor == Color.Red)
                {
                    ResetErrorColor(CmbFrom);
                }
            }

            if (ToStationText.Length > 100)
            {
                if (CmbTo.BackColor == SystemColors.Window)
                {
                    SetErrorColor(CmbTo, "Maximal 100 Zeichen erlaubt.");
                    NoError = false;
                }
            }
            else
            {
                if (CmbTo.BackColor == Color.Red)
                {
                    ResetErrorColor(CmbTo);
                }
            }

            if (CmbFrom.SelectedItem == null)
            {
                if (CmbFrom.Items.IndexOf(CmbFrom.Text) == -1)
                {
                    SetErrorColor(CmbFrom, "Bitte wählen sie ein Element aus der Auswahl aus.");
                    NoError = false;
                }
            }

            if (CmbTo.SelectedItem == null)
            {
                if (CmbTo.Items.IndexOf(CmbTo.Text) == -1)
                {
                    SetErrorColor(CmbTo, "Bitte wählen sie ein Element aus der Auswahl aus.");
                    NoError = false;
                }
            }

            return NoError;
        }

        private void BuildComponent()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Abfahrts Station");
            listView1.Columns.Add("Ankunfts Station");
            listView1.Columns.Add("Abfahrt");
            listView1.Columns.Add("Ankunft");
            listView1.Columns.Add("Dauer");
            listView1.Columns.Add("Umsteigen");

            stationBoardListView.View = View.Details;
            stationBoardListView.FullRowSelect = true;
            stationBoardListView.Columns.Add("Abfahrts Station");
            stationBoardListView.Columns.Add("Ankunfts Station");
            stationBoardListView.Columns.Add("Abfahrt");
            stationBoardListView.Columns.Add("Kategorie");
            stationBoardListView.Columns.Add("Anbieter");

            txb_Time.Text = DateTime.Now.ToString("hh:mm");
        }

        private void LoadRequestResultToCombobox(ComboBox cmb, bool executeRequest = false)
        {
            this.Enabled = false;

            StationsLoadFunction stationLoadFunction = new StationsLoadFunction();
            List<Station> stationlist = stationLoadFunction.Execute(cmb.Text);

            cmb.Items.Clear();
            foreach (Station station in stationlist)
            {
                cmb.Items.Add(station.Name);
            }

            this.Enabled = true;
            cmb.SelectionStart = cmb.Text.Length + 1;
        }

        private void SetErrorColor(object target, string Message)
        {
            if(target.GetType() == typeof(ComboBox))
            {
                ComboBox cmb = (ComboBox)target;
                if (cmb.BackColor == SystemColors.Window)
                {
                    cmb.BackColor = Color.Red;
                    cmb.ContextMenu = new ContextMenu();
                    cmb.ContextMenu.MenuItems.Add(Message);
                }
            }
        }

        private void ResetErrorColor(object target)
        {
            if (target.GetType() == typeof(ComboBox))
            {
                ComboBox cmb = (ComboBox)target;
                cmb.BackColor = SystemColors.Window;
                cmb.ContextMenu.MenuItems.Clear();
            }
        }

        private StationBoardRoot LoadStationBoard(string name)
        {
            Transport transportConnection = new Transport();

            return transportConnection.GetStationBoard(name);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MailSendForm form = new MailSendForm(listView1.SelectedItems[0]);
            form.Show();
            //Mail Massage
        }

        private void Button_Arrive_Click(object sender, EventArgs e)
        {
            button_Arrive.Enabled = false;
            button_Departure.Enabled = true;
        }
        
        private void button_Departure_Click(object sender, EventArgs e)
        {
            button_Departure.Enabled = false;
            button_Arrive.Enabled = true;
        }

        private void Button_MapFrom_Click(object sender, EventArgs e)
        {
            StationsLoadFunction stationsloadfunction = new StationsLoadFunction();
            List<Station> stations = stationsloadfunction.Execute(CmbFrom.Text);

            if(stations != null && stations.Any())
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
    }

    public class LoadRequestResultToCombobox
    {
        public LoadRequestResultToCombobox(ComboBox target)
        {
            Target = target;
        }

        public ComboBox Target { get; set; }

        public void Execute()
        {
            StationsLoadFunction stationLoadFunction = new StationsLoadFunction();
            List<Station> stationlist = stationLoadFunction.Execute(Target.Text);

            Target.Items.Clear();
            foreach (Station station in stationlist)
            {
                Target.Items.Add(station.Name);
            }

            Target.SelectionStart = Target.Text.Length + 1;
        }
    }
}
