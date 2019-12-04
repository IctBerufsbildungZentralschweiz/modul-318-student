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
        public Fahrplan()
        {
            InitializeComponent();
        }

        //globale Variablen
        int mode = 1; //Fenstermodus: 1 = Verbindung, 2 = Abfahrtsplan, 3 = Info
        string coordinates = "";
        ITransport transport = new Transport();

        //Ereignisse
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    try
                    {
                        sucheVerbindung();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "no results")
                        {
                            lstErgebnisse.Items.Clear();
                            lstErgebnisse.Items.Add("");
                            lstErgebnisse.Items.Add("Keine Verbindungen gefunden");
                            lstErgebnisse.Items.Add("");
                            lstErgebnisse.Items.Add("Bitte überprüfen Sie Ihre Eingabe");
                            lblDetail.Text = "Keine Verbindungen gefunden";
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ein unerwarteter Fehler ist aufgetreten: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 2:
                    try
                    {
                        suchePlan();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "no results")
                        {
                            lstErgebnisse.Items.Clear();
                            lstErgebnisse.Items.Add("");
                            lstErgebnisse.Items.Add("Keine Verbindungen gefunden");
                            lstErgebnisse.Items.Add("");
                            lstErgebnisse.Items.Add("Bitte überprüfen Sie Ihre Eingabe");
                            lblDetail.Text = "Keine Verbindungen gefunden";
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ein unerwarteter Fehler ist aufgetreten: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 3:
                    try
                    {
                        sucheInfos();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "no results")
                        {
                            lstErgebnisse.Items.Clear();
                            lstErgebnisse.Items.Add("");
                            lstErgebnisse.Items.Add("Keine Informationen gefunden");
                            lstErgebnisse.Items.Add("");
                            lstErgebnisse.Items.Add("Bitte überprüfen Sie Ihre Eingabe");
                            lblDetail.Text = "Keine Informationen gefunden";
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ein unerwarteter Fehler ist aufgetreten: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnNavVerbindung_Click(object sender, EventArgs e)
        {
            switchMode(1);
        }
        private void btnNavPlan_Click(object sender, EventArgs e)
        {
            switchMode(2);
        }
        private void btnNavInfo_Click(object sender, EventArgs e)
        {
            switchMode(3);
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
        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(coordinates);
        }
        private void btnRückfahrt_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                string text = txtAbfahrt.Text; //Zwischenspeicherung Abfahrtsstation
                txtAbfahrt.Text = txtAnkunft.Text;
                txtAnkunft.Text = text;
                try
                {
                    sucheVerbindung();
                }
                catch (Exception ex)
                {
                    if (ex.Message == "no results")
                    {
                        lstErgebnisse.Items.Clear();
                        lstErgebnisse.Items.Add("");
                        lstErgebnisse.Items.Add("Keine Verbindungen gefunden");
                        lstErgebnisse.Items.Add("");
                        lstErgebnisse.Items.Add("Bitte überprüfen Sie Ihre Eingabe");
                        lblDetail.Text = "Keine Verbindungen gefunden";
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ein unerwarteter Fehler ist aufgetreten: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnMail_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            string[] list = { lblDetail.Text.Replace("\n\r", " "), "", "", "", "", "", "", "", "", "", "", ""} ;
            int i = 1;
            foreach(string line in lstErgebnisse.Items)
            {
                list[i] = line;
                i++;
            }
            mail.openMail(list);
        }
            //Funktionen
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
            if (connections.ConnectionList.Count == 0)
            {
                throw new Exception("no results");
            }
            string currentAb = connections.ConnectionList.ElementAt(0).From.Station.Name;
            string currentAn = connections.ConnectionList.ElementAt(0).To.Station.Name;
            lblDetail.Text = currentAb + " -\n\r" + currentAn;
            lstErgebnisse.Items.Clear();
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
            btnMail.Enabled = true;
            btnMail.BackColor = Color.FromArgb(0, 0, 100);
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
            if (statboard.Entries.Count == 0)
            {
                throw new Exception("no results");
            }
            lstErgebnisse.Items.Clear();
            lblDetail.Text = "Abfahrtsplan ab\n\r" + statboard.Station.Name;
            lstErgebnisse.Items.Add("");
            for (int i = 0; i < 7; i++)
            {
                lstErgebnisse.Items.Add(
                    statboard.Entries.ElementAt(i).Stop.Departure.ToShortTimeString() +
                    " | " +
                    statboard.Entries.ElementAt(i).Number +
                    " | " +
                    statboard.Entries.ElementAt(i).To);
            }
            btnMail.Enabled = true;
            btnMail.BackColor = Color.FromArgb(0, 0, 100);
        }
        public void sucheInfos()
        {
            Stations stations = transport.GetStations(txtAbfahrt.Text);
            if (stations.StationList.Count == 0)
            {
                throw new Exception("no results");
            }
            Station station = stations.StationList.ElementAt(0);
            
            lstErgebnisse.Items.Clear();
            lblDetail.Text = "Informationen\n\r" + station.Name;
            lstErgebnisse.Items.Add("");
            
            string name = station.Name;
            string[] parts = name.Split(new string[] { ", "}, StringSplitOptions.None);
            int lines = 0;
            foreach (string part in parts)
            {
                lstErgebnisse.Items.Add(part);
                lines++;
            }
            do
            {
                lstErgebnisse.Items.Add("");
                lines++;
            } while (lines < 4);
            if (station.Coordinate.XCoordinate == 0 || station.Coordinate.YCoordinate == 0)
            {
                lstErgebnisse.Items.Add("Keine Koordinaten verfügbar");
            }
            else
            {
                coordinates =
                    "https://www.google.ch/maps/place/" +
                    station.Coordinate.XCoordinate +
                    "," +
                    station.Coordinate.YCoordinate;
                lstErgebnisse.Items.Add(coordinates);
                lblLink.Visible = true;
                //https://www.google.ch/maps/place/x,y
            }
            btnMail.Enabled = true;
            btnMail.BackColor = Color.FromArgb(0, 0, 100);
        }
        public void autoComplete(string text, ListBox into)
        {
            into.Items.Clear();
            Stations stations = transport.GetStations(text);
            if (stations.StationList.Count != 0)
            {
                foreach (Station station in stations.StationList)
                {
                    if (station.Name != null)
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
        public void switchMode(int index)
        {
            lstErgebnisse.Items.Clear();
            lblDetail.Text = "- - - - - - - - - - - - - - - - - -";
            lblLink.Visible = false;
            btnMail.Enabled = false;
            btnMail.BackColor = Color.FromArgb(224, 224, 224);

            //1 = Verbindungen, 2 = Abfahrtsplan, 3 = Informationen
            switch (index)
            {
                case 1:
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
                        btnRückfahrt.Visible = true;
                        btnMail.Width = 90;
                    }
                    break;
                case 2:
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
                        btnRückfahrt.Visible = false;
                        btnMail.Width = 264;
                    }
                    break;
                case 3:
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
                        btnRückfahrt.Visible = false;
                        btnMail.Width = 264;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
