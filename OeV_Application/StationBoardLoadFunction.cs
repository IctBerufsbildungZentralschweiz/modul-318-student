using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace OeV_Application
{
    public class StationBoardLoadFunction
    {
        public StationBoardLoadFunction()
        {

        }

        public StationBoardRoot Execute(string StationName)
        {
            // Load Station
            StationsLoadFunction loadfunction = new StationsLoadFunction();
            Station station = loadfunction.Execute(StationName).First();

            // Creaet Transport Object
            Transport transportconnection = new Transport();

            try
            {
                // Load and Return Stationboard
                return transportconnection.GetStationBoard(station.Name, station.Id);
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler beim Laden der Abfahrtstafel aufgetreten. Bitte versuchen sie es noch einmals");
                return null;
            }
        }
    }
}
