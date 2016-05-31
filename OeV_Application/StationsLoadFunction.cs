using System;
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

        ~StationsLoadFunction()
        {

        }

        public List<Station> Execute(string SearchText)
        {

            List<Station> ReturnStationList = new List<Station>();

            Transport transportConnection = new Transport();

            Stations stationsList = new Stations();

            if (!string.IsNullOrEmpty(SearchText))
            { 
                try
                {
                    stationsList = transportConnection.GetStations(SearchText);
                }
                catch
                {
                    MessageBox.Show("Es ist ein Fehler beim Laden der Station aufgetreten. Bitte versuchen sie es noch einmals");
                    return null;
                }
            
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
}