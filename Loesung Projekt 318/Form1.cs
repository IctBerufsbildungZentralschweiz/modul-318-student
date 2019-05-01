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

namespace Loesung_Projekt_318
{
	public partial class Form1 : Form
	{
		#region Membervariablen

		//Membervariablen
		List<string> fromStationId = new List<string>();
		List<Station> stationList = new List<Station>();
		Transport transport = new Transport();
		string departureTime = null;
		string departureDate = null;
		int isArriTime = 1;
		#endregion

		#region Initialization des Forms
		public Form1()
		{
			InitializeComponent();
			
		}
		#endregion

		#region Funktionen

		//Löschen von Eingaben in den Textboxen und inhalt von Comboxen
		private void OnClickDelete(object sender, EventArgs e)
		{
			cmbToStation.Items.Clear();
			cmbToStation.Text = "";
			txtToStation.Clear();
			cmbFromStation.Items.Clear();
			cmbFromStation.Text = "";
			txtFromStation.Clear();
		}

		//Zeigt Verbindungen in der ListView
		private void OnClickSearchConnection(object sender, EventArgs e)
		{
			setArrivalTime();
			SetDepartureDate();
			SetDepartureTime();
			lvConnections.Items.Clear();
		}

		//Zeigt

		//Funktion zur erhaltung alle Verbindungen im ListView
		private ListViewItem[] GetConnection(string fromStation, string toStation)
		{
			Connections ConnectionListView = transport.GetConnections(fromStation, toStation,
				departureDate, departureTime, isArriTime);

			try
			{
				ConnectionListView = transport.GetConnections(fromStation, toStation,
				departureDate, departureTime, isArriTime);
			}
			catch (Exception e)
			{
				ListViewItem[] errorListItemView = new ListViewItem[1];
				errorListItemView[0] = new ListViewItem("Fehler:\n");
				errorListItemView[0].SubItems.Add(e.Message);
				return errorListItemView;
			}

			ListViewItem[] listView = new ListViewItem[ConnectionListView.ConnectionList.Count];
			for(int i = 0; i < ConnectionListView.ConnectionList.Count; i++)
			{
				listView[i] = new ListViewItem(ConnectionListView.ConnectionList[i].From.Station.Name);
				listView[i].SubItems.Add(ConnectionListView.ConnectionList[i].To.Station.Name);
				listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].From.Departure).ToShortTimeString());
				listView[i].SubItems.Add(DateTime.Parse(ConnectionListView.ConnectionList[i].To.Arrival).ToShortTimeString());
				listView[i].SubItems.Add(TimeSpan.Parse(ConnectionListView.ConnectionList[i].Duration.Substring(3)).TotalMinutes.ToString() + "Min");
			}

			if(listView == null)
			{
				listView[0] = new ListViewItem("Es sind keine Verbindungen vorhanden");
			}
			return listView;
		}
		#endregion

		#region Methoden Set und Get für Membervariablen
		private void SetDepartureTime()
		{
			departureTime = (tpFromTime.Value.Hour) + ":" + tpFromTime.Value.Minute;
		}
		private void SetDepartureDate()
		{
			departureDate = tpFromDate.Value.Year + "-" + tpFromDate.Value.Month + "-" + tpFromDate.Value.Day;
		}
		private void setArrivalTime()
		{
			if(optIsArrival.Checked == true)
			{
				isArriTime = 1;
			}
			else if(optIsDeparture.Checked == true)
			{
				isArriTime = 0;
			}
		}
		#endregion
	}
}
