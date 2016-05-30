using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace OeV_Application
{
    public class StationBoardLoadFunction
    {
        public StationBoardLoadFunction()
        {

        }

        ~StationBoardLoadFunction()
        {

        }

        public StationBoardRoot Execute(string StationName)
        {
            // Load Station
            StationsLoadFunction loadfunction = new StationsLoadFunction();

            Station station = loadfunction.Execute(StationName).First();

            // Load StationBoard
            Transport transportconnection = new Transport();
            
            return transportconnection.GetStationBoard(station.Name, station.Id);

        }
    }
}
