﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace OeV_Application
{
    public class StationsLoadFunction
    {
        public StationsLoadFunction()
        {

        }

        List<Station> Stations = new List<Station>();

        public List<Station> Execute(string SearchText)
        {

            //List<Station> ReturnStationList = new List<Station>();

            //Create Transport Object
            Transport transportConnection = new Transport();

            Stations stationsList = new Stations();

            //Validator should check it, but it's saver wehen i do a new adjustment
            if (!string.IsNullOrEmpty(SearchText))
            { 
                try
                {
                    // Load all Connections that are semi equals to the searchtext
                    stationsList = transportConnection.GetStations(SearchText, "Es ist ein Problem beim Laden der Stationen aufgetreten. Bitee überprüfen sie, dass sie eine Verbindung zur API : transport.opendata.ch haben." +
                        "\n\n Sollten sie  Problemem mit den Verbindung haben, so probieren sie die Anfrage bitte nochmals zu einem anderen Zeitpunkt. Ist mit Ihrer Verbindung alles in Ordnung. So führen sie die Aktion nochmals aus.");
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler beim Laden der Station aufgetreten. Bitte versuchen sie es noch einmals");
                    return null;
                }
            
            }

            // Any Stations aviable, else Null Refrence Exception
            if (stationsList != null && stationsList.StationList != null && stationsList.StationList.Any())
            {
                //Loop all Stations. I would return List<Station> instead of Stations
                foreach (Station station in stationsList.StationList)
                {
                    Stations.Add(station);
                }
            }

            return Stations;
        }
    }
}