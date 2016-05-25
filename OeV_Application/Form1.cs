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
        }

        private bool Validator()
        {
            bool NoError = true; 
            string FromStationText = CmbFrom.Text;
            string ToStationText = CmbTo.Text;

            if(FromStationText.Length > 40)
            {
                if (CmbFrom.BackColor == SystemColors.Window)
                {
                    CmbFrom.BackColor = Color.Red;
                    CmbFrom.ContextMenu = new ContextMenu();
                    CmbFrom.ContextMenu.MenuItems.Add("Maximal 40 Zeichen erlaubt");
                    NoError = false;
                }
            }
            else
            {
                if (CmbFrom.BackColor == Color.Red)
                {
                    CmbFrom.BackColor = SystemColors.Window;
                    CmbFrom.ContextMenu.MenuItems.Clear();
                }
            }

            if (ToStationText.Length > 40)
            {
                if (CmbTo.BackColor == SystemColors.Window)
                {
                    CmbTo.BackColor = Color.Red;
                    CmbTo.ContextMenu = new ContextMenu();
                    CmbTo.ContextMenu.MenuItems.Add("Maximal 40 Zeichen erlaubt");
                    NoError = false;
                }
            }
            else
            {
                if (CmbTo.BackColor == Color.Red)
                {
                    CmbTo.BackColor = SystemColors.Window;
                    CmbTo.ContextMenu.MenuItems.Clear();
                }
            }

            return NoError;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TravelDateTime = DateTimePicker.Value;

            if (Validator())
            {
                ConnectionsLoadFunction connectionsLoader = new ConnectionsLoadFunction();
                Connections = connectionsLoader.Execute(CmbFrom.Text, CmbTo.Text);

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
                        //listviewitem.SubItems.Add(connection.To.Station.Name);
                        //listviewitem.SubItems.Add(
                        //    (Convert.ToDateTime(connection.From.Departure).Hour.ToString().Length > 1 ?
                        //        Convert.ToDateTime(connection.From.Departure).Hour.ToString() :
                        //        "0" + Convert.ToDateTime(connection.From.Departure).Hour.ToString())
                        //        + ":" +
                        //    (Convert.ToDateTime(connection.From.Departure).Minute.ToString().Length > 1 ?
                        //        Convert.ToDateTime(connection.From.Departure).Minute.ToString() :
                        //        "0" + Convert.ToDateTime(connection.From.Departure).Minute.ToString())
                        //        );

                        //listviewitem.SubItems.Add(
                        //    (Convert.ToDateTime(connection.To.Arrival).Hour.ToString().Length > 1 ?
                        //        Convert.ToDateTime(connection.To.Arrival).Hour.ToString() :
                        //        "0" + Convert.ToDateTime(connection.To.Arrival).Hour.ToString())
                        //        + ":" +
                        //    (Convert.ToDateTime(connection.To.Arrival).Minute.ToString().Length > 1 ?
                        //        Convert.ToDateTime(connection.To.Arrival).Minute.ToString() :
                        //        "0" + Convert.ToDateTime(connection.To.Arrival).Minute.ToString())
                        //        );

                        //TimeSpan duration = TimeSpan.ParseExact(connection.Duration,"dd'd'hh':'mm':'ss",null);

                        //listviewitem.SubItems.Add(
                        //    (duration.Hours.ToString().Length > 1 ? duration.Hours.ToString() : "0" + duration.Hours.ToString())
                        //    + ":" +
                        //    (duration.Minutes.ToString().Length > 1 ? duration.Minutes.ToString() : "0" + duration.Minutes.ToString())
                        //    );

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

        private void LoadRequestResultToCombobox(ComboBox cmb, bool executeRequest = false)
        {
            if (string.IsNullOrEmpty(cmb.Text) ? false : cmb.Text.Length >= 4 && cmb.SelectedItem == null || executeRequest)
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
    }

    public class StationsLoadFunction
    {
        public StationsLoadFunction()
        {
            
        }

        ~StationsLoadFunction()
        {

        }

        public List<Station> Execute(string SearchText)
        {

            List<Station> ReturnStationList = new List<Station>();

            Transport transportConnection = new Transport();

            Stations stationsList = new Stations();

            if(!string.IsNullOrEmpty(SearchText))
            {
                stationsList = transportConnection.GetStations(SearchText);
            }

            if (stationsList.StationList.Any())
            {
                foreach (Station station in stationsList.StationList)
                {
                    ReturnStationList.Add(station);
                }
            }

            return ReturnStationList;
        }
    }

    public class ConnectionsLoadFunction
    {
        public ConnectionsLoadFunction()
        {

        }

        ~ConnectionsLoadFunction()
        {

        }

        public List<Connection> Execute(string FromStation, string ToStation)
        {
            Transport transportitem = new Transport();

            List<Connection> connections = new List<Connection>();

            foreach (Connection connection in transportitem.GetConnections(FromStation, ToStation).ConnectionList)
            {
                connections.Add(connection);
            }

            return connections;
        }
    }
}
