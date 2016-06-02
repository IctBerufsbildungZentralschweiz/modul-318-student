using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace OeV_Application
{
    public class ConnectionsLoadFunction
    {
        public ConnectionsLoadFunction()
        {
            Connections = new List<Connection>();
        }

        public List<Connection> Connections { get; set; }
        

        public List<Connection> Execute(string FromStation, string ToStation, DateTime date, bool isArrivalTime = false)
        { 
            Transport transportitem = new Transport();

            try
            {
                // Load all Connections
                var connectionlist = transportitem.GetConnectionsSpecificTime(FromStation, ToStation, date, "Es ist ein Problem beim Laden der Verbindungen aufgetreten. Bitee überprüfen sie, dass sie eine Verbindung zur API : transport.opendata.ch haben." +
                        "\n\n Sollten sie  Problemem mit den Verbindung haben, so probieren sie die Anfrage bitte nochmals zu einem anderen Zeitpunkt. Ist mit Ihrer Verbindung alles in Ordnung. So führen sie die Aktion nochmals aus.",  isArrivalTime).ConnectionList;

                foreach (Connection connection in connectionlist)
                {
                    //Loop all Connections. I would return List<connection> instead of conections
                    Connections.Add(connection);
                }
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler beim Laden der Verbindungen aufgetreten. Bitte versuchen sie es noch einmals");
                return null;
            }            

            return Connections;
        }
    }
}
