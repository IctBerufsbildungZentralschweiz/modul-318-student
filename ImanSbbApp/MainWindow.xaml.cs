using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImanSbbApp
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }

        public void getStationbyTyping(ComboBox comboBox)
        {
            ITransport it = new Transport();
            if (!string.IsNullOrEmpty(comboBox.Text))
            {
                List<Station> stations = it.GetStations(comboBox.Text).StationList;
                if (stations.Count > 0)
                {
                    foreach (Station s in stations)
                    {
                        comboBox.Items.Add(s.Name.ToString());
                    }
                }
            }

        }

        private void setFocusDropdownOpen(ComboBox comboBox)
        {
            comboBox.IsDropDownOpen = true;
        }

        private void comboBoxFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            setFocusDropdownOpen(comboBoxFrom);
        }

        private void comboBoxFrom_KeyUp(object sender, KeyEventArgs e)
        {
            getStationbyTyping(comboBoxFrom);
        }

        private void comboBoxTo_GotFocus(object sender, RoutedEventArgs e)
        {
            setFocusDropdownOpen(comboBoxTo);
        }

        private void comboBoxTo_KeyUp(object sender, KeyEventArgs e)
        {
            getStationbyTyping(comboBoxTo);
        }

        private void btnSearchConnection_Click(object sender, RoutedEventArgs e)
        {
            SwissTransport.Transport t = new SwissTransport.Transport();

            string From = comboBoxFrom.Text;
            string To = comboBoxTo.Text;

            List<SwissTransport.Connection> searchResConnections = t.GetConnections(From, To).ConnectionList;
            foreach (SwissTransport.Connection c in searchResConnections)
            {
                DisplayConnection dp = new DisplayConnection(c.To.Arrival, c.From.Departure, c.Duration, c.From.Platform);
                viewModel.Connections.Add(dp);
            }
        }

        //Methoden für Tab Abfahrtstafel 
        private void comboBoxStation_GotFocus(object sender, RoutedEventArgs e)
        {
            setFocusDropdownOpen(comboBoxStation);
        }
        private void comboBoxStation_KeyUp(object sender, KeyEventArgs e)
        {
            getStationbyTyping(comboBoxStation);
        }

        private void btnSearchStationConnections_Click(object sender, RoutedEventArgs e)
        {
            ITransport t = new Transport();

            if (!string.IsNullOrEmpty(comboBoxStation.Text))
            {         
                List<Station> st = t.GetStations(comboBoxStation.Text).StationList;

                if(st.Count > 0)
                {
                    foreach (Station s in st)
                    {
                        StationBoardRoot sbr = t.GetStationBoard(s.Name, s.Id);
                        List<StationBoard> sb = sbr.Entries;

                        foreach (StationBoard bb in sb)
                        {
                            DisplayBoard displayBoard = new DisplayBoard(bb.Name, bb.To, bb.Stop.Departure.ToString());
                            viewModel.Board.Add(displayBoard);
                        }
                    }
                }
            }
        }
    }
}


