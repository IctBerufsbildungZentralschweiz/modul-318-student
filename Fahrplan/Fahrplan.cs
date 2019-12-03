using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Fahrplan
{
    public partial class Fahrplan : Form
    {
        //Fenstermodus: 1 = Verbindung, 2 = Abfahrtsplan, 3 = Info
        int mode = 1;
        ITransport transport = new Transport();
        public void sucheVerbindung()
        {
            string dateTime = 
                datDatum.Value.Year.ToString() +
                "-" +
                datDatum.Value.Month.ToString() +
                "-" +
                datDatum.Value.Day.ToString() +
                "T" +
                datZeit.Value.Hour.ToString() +
                "%3A" +
                datZeit.Value.Minute.ToString(); //2019-12-31T23%3A55
            Connections connections = transport.GetConnections(txtAbfahrt.Text, txtAnkunft.Text, dateTime);
                        
            lstErgebnisse.Items.Clear();
            string currentAb = txtAbfahrt.Text;
            string currentAn = txtAnkunft.Text;
            lblDetail.Text = currentAb + " -\n\r" + currentAn;
            lstErgebnisse.Items.Add("");
            for (int i = 0; i < 4; i++)
            {
                if (currentAb.Length > 10)
                {
                    currentAb = currentAb.Substring(0, 8) + "...";
                }
                if (currentAn.Length > 10)
                {
                    currentAn = currentAn.Substring(0, 8) + "...";
                }
                lstErgebnisse.Items.Add(
                    Convert.ToDateTime(connections.ConnectionList.ElementAt(i).From.Departure).ToShortTimeString() +
                    " | " +
                    currentAb +
                    " - " +
                    currentAn +
                    " | " +
                    Convert.ToDateTime(connections.ConnectionList.ElementAt(i).To.Arrival).ToShortTimeString());

                lstErgebnisse.Items.Add("");
            }
        }
        public void suchePlan()
        {
            string dateTime =
                datDatum.Value.Year.ToString() +
                "-" +
                datDatum.Value.Month.ToString() +
                "-" +
                datDatum.Value.Day.ToString() +
                "T" +
                datZeit.Value.Hour.ToString() +
                "%3A" +
                datZeit.Value.Minute.ToString(); //2019-12-31T23%3A55
            StationBoardRoot statboard = transport.GetStationBoard(txtAbfahrt.Text, "", dateTime);

            lstErgebnisse.Items.Clear();
            string currentAb = txtAbfahrt.Text;
            string currentAn = "";
            lblDetail.Text = currentAb;
            lstErgebnisse.Items.Add("");
            for (int i = 0; i < 4; i++)
            {
                currentAn = statboard.Entries.ElementAt(i).To;
                if (currentAb.Length > 10)
                {
                    currentAb = currentAb.Substring(0, 8) + "...";
                }
                if (currentAn.Length > 10)
                {
                    currentAn = currentAn.Substring(0, 8) + "...";
                }
                lstErgebnisse.Items.Add(
                    statboard.Entries.ElementAt(i).Stop.Departure +
                    " | " +
                    currentAb +
                    " - " +
                    currentAn +
                    " | " +
                    statboard.Entries.ElementAt(i).Stop.Departure);
            }
        }
        public void sucheInfos()
        {

        }
        public void autoComplete(string text, ListBox into)
        {
            into.Items.Clear();
            Stations stations = transport.GetStations(text);
            if (stations.StationList.Count != 0)
            {
                foreach (Station station in stations.StationList)
                {
                    if(station.Name != null)
                    {
                        into.Items.Add(station.Name);
                    }
                }
                if (stations.StationList.ElementAt(0).Name == text)
                {
                    into.Items.Clear();
                }
            }
        }
        public void showDetail(int index)
        {
            
        }

        public Fahrplan()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    //try
                    //{
                    sucheVerbindung();
                    //}
                    //catch (Exception ex)
                    //{
                    //MessageBox.Show("Fehler: " + ex);
                    //}
                    break;
                case 2:
                    try
                    {
                        //suchePlan();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex);
                    }
                    break;
                case 3:
                    try
                    {
                        sucheInfos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler: " + ex);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnNavVerbindung_Click(object sender, EventArgs e)
        {
            if (mode == 2 || mode == 3)
            {
                mode = 1;
                lblTitel.Text = "Verbindung";

                btnNavVerbindung.BackColor = Color.White;
                btnNavVerbindung.ForeColor = Color.Black;
                btnNavVerbindung.FlatAppearance.MouseOverBackColor = Color.White;
                btnNavPlan.BackColor = Color.FromArgb(0, 0, 100);
                btnNavPlan.ForeColor = Color.White;
                btnNavPlan.FlatAppearance.MouseOverBackColor = Color.Navy;
                btnNavInfo.BackColor = Color.FromArgb(0, 0, 100);
                btnNavInfo.ForeColor = Color.White;
                btnNavInfo.FlatAppearance.MouseOverBackColor = Color.Navy;

                pnlAnkunft.Visible = true;
                lstAnkunft.Visible = true;
                lblNach.Visible = true;
                datDatum.Visible = true;
                datZeit.Visible = true;
                lblDate.Visible = true;
            }
        }
        private void btnNavPlan_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 3)
            {
                mode = 2;
                lblTitel.Text = "Abfahrtsplan";

                btnNavVerbindung.BackColor = Color.FromArgb(0, 0, 100);
                btnNavVerbindung.ForeColor = Color.White;
                btnNavVerbindung.FlatAppearance.MouseOverBackColor = Color.Navy;
                btnNavPlan.BackColor = Color.White;
                btnNavPlan.ForeColor = Color.Black;
                btnNavPlan.FlatAppearance.MouseOverBackColor = Color.White;
                btnNavInfo.BackColor = Color.FromArgb(0, 0, 100);
                btnNavInfo.ForeColor = Color.White;
                btnNavInfo.FlatAppearance.MouseOverBackColor = Color.Navy;

                pnlAnkunft.Visible = false;
                lstAnkunft.Visible = false;
                lblNach.Visible = false;
                datDatum.Visible = true;
                datZeit.Visible = true;
                lblDate.Visible = true;
            }
        }
        private void btnNavInfo_Click(object sender, EventArgs e)
        {
            if (mode == 1 || mode == 2)
            {
                mode = 3;
                lblTitel.Text = "Stationsinformationen";

                btnNavVerbindung.BackColor = Color.FromArgb(0, 0, 100);
                btnNavVerbindung.ForeColor = Color.White;
                btnNavVerbindung.FlatAppearance.MouseOverBackColor = Color.Navy;
                btnNavPlan.BackColor = Color.FromArgb(0, 0, 100);
                btnNavPlan.ForeColor = Color.White;
                btnNavPlan.FlatAppearance.MouseOverBackColor = Color.Navy;
                btnNavInfo.BackColor = Color.White;
                btnNavInfo.ForeColor = Color.Black;
                btnNavInfo.FlatAppearance.MouseOverBackColor = Color.White;

                pnlAnkunft.Visible = false;
                lstAnkunft.Visible = false;
                lblNach.Visible = false;
                datDatum.Visible = false;
                datZeit.Visible = false;
                lblDate.Visible = false;
            }
        }
        private void txtAbfahrt_TextChanged(object sender, EventArgs e)
        {
            if (txtAbfahrt.Text != "")
            {
                autoComplete(txtAbfahrt.Text, lstAbfahrt);
            }
        }
        private void txtAnkunft_TextChanged(object sender, EventArgs e)
        {
            if (txtAnkunft.Text != "")
            {
                autoComplete(txtAnkunft.Text, lstAnkunft);
            }
        }
        private void lstAbfahrt_Click(object sender, EventArgs e)
        {
            if (lstAbfahrt.SelectedIndex != -1)
            {
                txtAbfahrt.Text = lstAbfahrt.SelectedItem.ToString();
            }
        }
        private void lstAnkunft_Click(object sender, EventArgs e)
        {
            if (lstAnkunft.SelectedIndex != -1)
            {
                txtAnkunft.Text = lstAnkunft.SelectedItem.ToString();
            }
        }
    }
}
