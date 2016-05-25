using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

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
                stationsList = transportConnection.GetStations(SearchText);
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