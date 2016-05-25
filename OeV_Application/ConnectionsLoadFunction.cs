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

        public List<Connection> Execute(string FromStation, string ToStation)
        {
            Transport transportitem = new Transport();

            List<Connection> connections = new List<Connection>();

            foreach (Connection connection in transportitem.GetConnections(FromStation, ToStation).ConnectionList)
            {
                connections.Add(connection);
            }

            return connections;
        }
    }
}
