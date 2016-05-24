using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OeV_Application
{
    public partial class Form1 : Form
    {
        string FromSearchText;
        string ToSearchText;
        string ViaSearchText;
        DateTime TravelDateTime;
        Connections Connections;

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
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromSearchText = FromTextbox.Text;
            ToSearchText = ToTextBox.Text;
            ViaSearchText = ViaTextBox.Text;
            TravelDateTime = DateTimePicker.Value;

            if (Validator())
            {
                Transport transportitem = new Transport();

                Connections = transportitem.GetConnections(FromSearchText, ToSearchText);

                if (Connections.ConnectionList.Any())
                {
                    foreach (Connection connection in Connections.ConnectionList)
                    {
                        ListViewItem listviewitem = new ListViewItem(connection.From.Station.Name);
                        listviewitem.SubItems.Add(connection.To.Station.Name);
                        listviewitem.SubItems.Add(connection.From.DepartureTimestamp);
                        listviewitem.SubItems.Add(connection.To.ArrivalTimestamp);
                        listviewitem.SubItems.Add(connection.Duration);
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
    }
}
