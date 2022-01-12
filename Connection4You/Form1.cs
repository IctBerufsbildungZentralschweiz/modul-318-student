using SwissTransport.Core;
using SwissTransport.Models;

namespace Connection4You
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ITransport transport = new Transport();
        Connections connections = new Connections();
        StationBoardRoot stationBoardRoot = new StationBoardRoot();

        private void SearchConnection(object sender, EventArgs e)
        {
            try
            {
                if (cbFromLocation.Text != "" || cbToLocation.Text != "")
                {
                    if (cbFromLocation.Text == cbToLocation.Text)
                    {
                        MessageBox.Show("From and To cannot be the same!");
                    }

                    dgvFromToSearch.Rows.Clear();

                    connections = transport.GetConnections(cbFromLocation.Text, cbToLocation.Text, dtpFromDate.Value.Date, dtpFromTime.Value);

                    foreach (Connection connection in connections.ConnectionList)
                    {
                        DataGridViewRow row = (DataGridViewRow)dgvFromToSearch.Rows[0].Clone();
                        row.Cells[0].Value = connection.From.Station.Name;
                        row.Cells[1].Value = connection.To.Station.Name;
                        row.Cells[2].Value = connection.From.Departure;
                        row.Cells[3].Value = connection.To.Arrival;
                        dgvFromToSearch.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: \n" + ex);
            }
        }

        private void ChangeFromAndToText(object sender, EventArgs e)
        {
            string tbValueFrom = cbFromLocation.Text;
            string tbValueTo = cbToLocation.Text;

            cbFromLocation.Text = tbValueTo;
            cbToLocation.Text = tbValueFrom;
        }

        private void searchStation(object sender, EventArgs e)
        {
            try { 
                dgvSearchByStation.Rows.Clear();

                string searchedStation = cbSearchStation.Text;

                stationBoardRoot = transport.GetStationBoard(searchedStation, "id");

                foreach (StationBoard stationBoard in stationBoardRoot.Entries)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvSearchByStation.Rows[0].Clone();

                    row.Cells[0].Value = stationBoard.To;
                    row.Cells[1].Value = stationBoard.Category;
                    row.Cells[2].Value = stationBoard.Operator;

                    dgvSearchByStation.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: \n" + ex);
            }
        }

        private void loadComboboxFromSuggestions(object sender, EventArgs e)
        {
            string searchedStation = cbFromLocation.Text;

            if (searchedStation != "")
            { 
                Stations stations = transport.GetStations(searchedStation);

                foreach (Station station in stations.StationList)
                {
                    cbFromLocation.Items.Add(station.Name);
                }
            }
        }

        private void loadComboboxToSuggestions(object sender, EventArgs e)
        {
            string searchedStation = cbToLocation.Text;

            if (searchedStation != "")
            { 
                Stations stations = transport.GetStations(searchedStation);

                foreach (Station station in stations.StationList)
                {
                    cbToLocation.Items.Add(station.Name);
                }
            }
        }

        private void loadComboboxSearchStationSuggestions(object sender, EventArgs e)
        {
            string searchedStation = cbSearchStation.Text;

            if (searchedStation != "")
            {
                Stations stations = transport.GetStations(searchedStation);

                foreach (Station station in stations.StationList)
                {
                    cbSearchStation.Items.Add(station.Name);
                }
            }
        }
    }
}