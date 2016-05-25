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

namespace OeV_Application
{
    public partial class Form1 : Form
    {
        DateTime TravelDateTime;
        List<Connection> Connections;

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

                Connections = connectionsLoader.Execute(FromSearchText, ToSearchText);

                if (Connections.Any())
                {
                    PrepareConnections();
                    listView1.Items.Clear();
                    foreach (Connection connection in Connections)
                    {
                        ListViewItem listviewitem = new ListViewItem(connection.From.Station.Name);
                        listviewitem.SubItems.Add(connection.To.Station.Name);
                        listviewitem.SubItems.Add(connection.From.Departure);
                        listviewitem.SubItems.Add(connection.To.Arrival);
                        listviewitem.SubItems.Add("1");

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

        private void CmbFrom_TextChanged(object sender, EventArgs e)
        {
            LoadRequestResultToCombobox(CmbFrom);
        }

        private void CmbTo_TextChanged(object sender, EventArgs e)
        {
            LoadRequestResultToCombobox(CmbTo);
        }

        private void CmbFrom_KeyPress(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
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
                    CmbFrom.DroppedDown = true;
                    break;
                case Keys.Enter:
                    LoadRequestResultToCombobox(CmbFrom, true);
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

            if (FromStationText.Length > 40)
            {
                if (CmbFrom.BackColor == SystemColors.Window)
                {
                    SetErrorColor(CmbFrom, "Maximal 40 Zeichen erlaubt.");
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

            if (ToStationText.Length > 40)
            {
                if (CmbTo.BackColor == SystemColors.Window)
                {
                    SetErrorColor(CmbTo, "Maximal 40 Zeichen erlaubt.");
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

            if(CmbFrom.SelectedItem == null)
            {
                if(CmbFrom.Items.IndexOf(CmbFrom.Text) == -1)
                {
                    SetErrorColor(CmbFrom, "Bitte wählen sie ein Element aus der Auswahl aus.");
                    NoError = false;
                }
            }
            
            if(CmbTo.SelectedItem == null)
            {
                if(CmbTo.Items.IndexOf(CmbTo.Text) == -1)
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
        }

        private void LoadRequestResultToCombobox(ComboBox cmb, bool executeRequest = false)
        {
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null || executeRequest)
            {
                this.Enabled = false;

                StationsLoadFunction stationLoadFunction = new StationsLoadFunction();
                List<Station> stationlist = stationLoadFunction.Execute(cmb.Text);

                cmb.Items.Clear();
                cmb.Items.Add("Alle Verbindungen");
                foreach (Station station in stationlist)
                {
                    cmb.Items.Add(station.Name);
                }

                this.Enabled = true;
                cmb.SelectionStart = cmb.Text.Length + 1;
            }
        }         

        private void PrepareConnections()
        {
            foreach(Connection connection in Connections)
            {
               connection.From.Departure = (Convert.ToDateTime(connection.From.Departure).Hour.ToString().Length > 1 ?
                               Convert.ToDateTime(connection.From.Departure).Hour.ToString() :
                               "0" + Convert.ToDateTime(connection.From.Departure).Hour.ToString())
                               + ":" +
                           (Convert.ToDateTime(connection.From.Departure).Minute.ToString().Length > 1 ?
                               Convert.ToDateTime(connection.From.Departure).Minute.ToString() :
                               "0" + Convert.ToDateTime(connection.From.Departure).Minute.ToString());

                connection.To.Arrival = (Convert.ToDateTime(connection.To.Arrival).Hour.ToString().Length > 1 ?
                                Convert.ToDateTime(connection.To.Arrival).Hour.ToString() :
                                "0" + Convert.ToDateTime(connection.To.Arrival).Hour.ToString())
                                + ":" +
                            (Convert.ToDateTime(connection.To.Arrival).Minute.ToString().Length > 1 ?
                                Convert.ToDateTime(connection.To.Arrival).Minute.ToString() :
                                "0" + Convert.ToDateTime(connection.To.Arrival).Minute.ToString());

                TimeSpan duration = TimeSpan.ParseExact(connection.Duration, "dd'd'hh':'mm':'ss", null);

                connection.Duration = (duration.Hours.ToString().Length > 1 ? duration.Hours.ToString() : "0" + duration.Hours.ToString())
                    + ":" +
                    (duration.Minutes.ToString().Length > 1 ? duration.Minutes.ToString() : "0" + duration.Minutes.ToString());
            }
           
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
        private void button2_Click(object sender, EventArgs e)
        {
            StationBoardRoot stationboardroot = LoadStationBoard(cmbBoardName.SelectedItem != null ? cmbBoardName.SelectedItem.ToString() : !string.IsNullOrEmpty(cmbBoardName.Text) ? cmbBoardName.Text : string.Empty);

            foreach (StationBoard stationboard in stationboardroot.Entries)
            {
                ListViewItem listViewItem = new ListViewItem(stationboardroot.Station.Name);
                listViewItem.SubItems.Add(stationboard.To);
                listViewItem.SubItems.Add(stationboard.Stop.Departure.ToString());
                listViewItem.SubItems.Add(stationboard.Category);
                listViewItem.SubItems.Add(stationboard.Operator);                
                stationBoardListView.Items.Add(listViewItem);
            }
        }
    }


}
