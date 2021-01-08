namespace SwissTransportGUI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Text.RegularExpressions;
    using SwissTransport;
    public partial class FahrplanApp : Form
    {

        #region TAB: Verbindungssuche
        private ListViewItem ShowConnections(Connection connection)
        {
            string[] connections = { connection.From.Departure.ToString().Substring(0, 10), connection.From.Departure.ToString().Substring(11, 5), connection.From.Station.Name, connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform };
            return new ListViewItem(connections);
        }

        public FahrplanApp()
        {
            InitializeComponent();
            Txt_Time.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Cb_ConnectionFrom_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionFrom);
            ClearStationNames(Cb_ConnectionFrom);
            AddStationNames(Cb_ConnectionFrom);
        }

        private void Cb_ConnectionTo_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionTo);
            ClearStationNames(Cb_ConnectionTo);
            AddStationNames(Cb_ConnectionTo);
        }

        //Validiert den Text in der Zeit ComoBox
        private bool ValidateTime(TextBox textBox)
        {
            string TimeToValidate = textBox.Text;
            bool returnValue = true;
            Match match = Regex.Match(TimeToValidate, @"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$", RegexOptions.IgnoreCase);
            

            if (!match.Success)
            {
                returnValue = false;
            }
            return returnValue;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Lv_Connections.Items.Clear();

            if (ValidateStations(Cb_ConnectionFrom) && ValidateStations(Cb_ConnectionTo) && ValidateTime(Txt_Time))
            {
                // Setzt das Datumsformat
                string Date = Dtp_Date.Value.Year + "-" + Dtp_Date.Value.Month + "-" + Dtp_Date.Value.Day; 

                foreach (global::SwissTransport.Connection connection in SwissTrans.GetConnections(Cb_ConnectionFrom.Text, Cb_ConnectionTo.Text, Date, Txt_Time.Text).ConnectionList)
                {
                    Lv_Connections.Items.Add(ShowConnections(connection));
                }
            }
            if (!ValidateTime(Txt_Time))
            {
                Txt_Time.BackColor = Color.FromArgb(255, 92, 92);
                MessageBox.Show("Please Check Time Format (HH:mm)");
            }
            if (!ValidateStations(Cb_ConnectionFrom))
            {
                SetCbBackgroundToRed(Cb_ConnectionFrom);
                MessageBox.Show("Please Check the Value");
            }
            if (!ValidateStations(Cb_ConnectionTo))
            {
                SetCbBackgroundToRed(Cb_ConnectionTo);
                MessageBox.Show("Please Check the Value");
            }
        }
        private void Txt_Time_TextChanged(object sender, EventArgs e)
        {
            Txt_Time.BackColor = SystemColors.Window;
        }
        #endregion

        #region TAB: Abfahrtsübersicht
        private ListViewItem ShowDepartures(StationBoard stationBoard)
        {
            string[] departures = { stationBoard.Stop.Departure.ToString().Substring(11, 5), stationBoard.To, stationBoard.Category + stationBoard.Number };
            return new ListViewItem(departures);
        }
        private void Cb_ConnectionsFromDepBoard_TextUpdate(object sender, EventArgs e)
        {
            ResetComboboxBackground(Cb_ConnectionsFromDepBoard);
            ClearStationNames(Cb_ConnectionsFromDepBoard);
            AddStationNames(Cb_ConnectionsFromDepBoard);
        }
        private void Btn_Search_DepBoard_Click(object sender, EventArgs e)
        {
            lv_DepartureBoard.Items.Clear();
            if (ValidateStations(Cb_ConnectionsFromDepBoard))
            {
                foreach (StationBoard stationBoard in SwissTrans.GetStationBoard(Cb_ConnectionsFromDepBoard.Text, string.Empty).Entries)
                {
                    lv_DepartureBoard.Items.Add(ShowDepartures(stationBoard));
                }
            }
            else
            {
                SetCbBackgroundToRed(Cb_ConnectionsFromDepBoard);
                MessageBox.Show("Überprüfe deine Eingabe");
            }
        }
        #endregion

        #region TAB: sonstige Funktionen

        readonly Transport SwissTrans = new Transport();

        // Setzt die Comobox Farbe zurück
        private void ResetComboboxBackground(ComboBox comboBox)
        {
            comboBox.BackColor = SystemColors.Window;
        }

        // Hinzufügen von Stationsnamen basierend auf Benutzereingaben zu einer Combobox.
        private void AddStationNames(ComboBox comboBox)
        {
            try {
                comboBox.DroppedDown = true;
                foreach (global::SwissTransport.Station station in SwissTrans.GetStations(comboBox.Text).StationList)
                {
                    if (station.Name != null)
                        comboBox.Items.Add(station.Name);
                }
            }
            catch
            {
                MessageBox.Show("Fehler");
            }
            
        }

        //Löscht die StationNames aus der Comobox.
        private void ClearStationNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
        }

        // Prüft ob die ComoBox ausgefüllt ist.
        private bool ValidateStations(ComboBox comboBox)
        {
            bool returnValue = true;
            if (comboBox.Text.Length <= 0 || comboBox.Text == null)
            {
                returnValue = false;
            }
            return returnValue;
        }

        // Setzt die Hintergrundfarbe auf rot wen eine Falsche Eingabe gemacht wird.
        private void SetCbBackgroundToRed(ComboBox comboBox)
        {
            comboBox.BackColor = Color.FromArgb(255, 92, 92);
        }

        // Uhrzeit anzeigen lassen
        private void SwissTransportApp_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Cb_ConnectionFrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Lv_Connections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dtp_Date_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}