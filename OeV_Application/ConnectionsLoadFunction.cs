using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

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

            var connectionlist = transportitem.GetConnectionsSpecificTime(FromStation, ToStation, date, isArrivalTime).ConnectionList;

            foreach (Connection connection in connectionlist)
            {
                connections.Add(connection);
            }

            return connections;
        }
    }
}
