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

        }

        ~ConnectionsLoadFunction()
        {

        }

        public List<Connection> Execute(string FromStation, string ToStation, DateTime date, bool isArrivalTime = false)
        { 
            Transport transportitem = new Transport();

            List<Connection> connections = new List<Connection>();

            try
            {
                var connectionlist = transportitem.GetConnectionsSpecificTime(FromStation, ToStation, date, isArrivalTime).ConnectionList;

                foreach (Connection connection in connectionlist)
                {
                    connections.Add(connection);
                }
            }
            catch
            {
                MessageBox.Show("Es ist ein Fehler beim Laden der Verbindungen aufgetreten. Bitte versuchen sie es noch einmals");
                return null;
            }

            

            

            return connections;
        }
    }
}
