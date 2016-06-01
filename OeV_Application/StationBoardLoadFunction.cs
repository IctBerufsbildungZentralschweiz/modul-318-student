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

        StationBoardRoot StationBoard { get; set; }

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
                StationBoard = transportconnection.GetStationBoard(station.Name, station.Id, "Es ist ein Problem beim Laden der Abfahrtstafel aufgetreten. Bitee überprüfen sie, dass sie eine Verbindung zur API : transport.opendata.ch haben." +
                        "\n\n Sollten sie  Problemem mit den Verbindung haben, so probieren sie die Anfrage bitte nochmals zu einem anderen Zeitpunkt. Ist mit Ihrer Verbindung alles in Ordnung. So führen sie die Aktion nochmals aus.");

                return StationBoard;
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler beim Laden der Abfahrtstafel aufgetreten. Bitte versuchen sie es noch einmals");
                return null;
            }
        }
    }
}
