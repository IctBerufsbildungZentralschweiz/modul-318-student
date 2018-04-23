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

        //OnClick Methoden der Anforderung A001
        /* 
        private void btnSearchFrom_Click(object sender, RoutedEventArgs e)
        {
            ITransport i = new Transport();
            if (!string.IsNullOrEmpty(comboBoxFrom.Text))
            {
                List<Station> stations = i.GetStations(comboBoxFrom.Text).StationList;
                if (stations.Count > 0)
                {
                    foreach (Station s in stations)
                    {
                        comboBoxFrom.Items.Add(s.Name.ToString());
                        comboBoxFrom.IsDropDownOpen = true;

                    }
                }
            }
        }

        private void btnSearchTo_Click(object sender, RoutedEventArgs e)
        {
            ITransport i = new Transport();
            if (!string.IsNullOrEmpty(comboBoxTo.Text))
            {
                List<Station> stations = i.GetStations(comboBoxTo.Text).StationList;
                if (stations.Count > 0)
                {
                    foreach (Station s in stations)
                    {
                        comboBoxTo.Items.Add(s.Name.ToString());
                        comboBoxTo.IsDropDownOpen = true;
                    }
                }
            }
        }
        */

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

        private void comboBoxFrom_GotFocus(object sender, RoutedEventArgs e)
        {
            comboBoxFrom.IsDropDownOpen = true;
        }

        private void comboBoxFrom_KeyUp(object sender, KeyEventArgs e)
        {
            ITransport it = new Transport();
            if (!string.IsNullOrEmpty(comboBoxFrom.Text))
            {
                List<Station> stations = it.GetStations(comboBoxFrom.Text).StationList;
                if (stations.Count > 0)
                {
                    comboBoxFrom.IsDropDownOpen = true;
                    foreach (Station s in stations)
                    {
                        comboBoxFrom.Items.Add(s.Name.ToString());
                    }
                }
            }
        }

        private void comboBoxTo_GotFocus(object sender, RoutedEventArgs e)
        {
            comboBoxTo.IsDropDownOpen = true;
        }

        private void comboBoxTo_KeyUp(object sender, KeyEventArgs e)
        {
            ITransport t = new Transport();

            if(!string.IsNullOrEmpty(comboBoxTo.Text))
            {
                List<Station> stations = t.GetStations(comboBoxTo.Text).StationList;
                foreach(Station s in stations)
                {
                    comboBoxTo.Items.Add(s.Name);
                }
            }
        }

    }
}


