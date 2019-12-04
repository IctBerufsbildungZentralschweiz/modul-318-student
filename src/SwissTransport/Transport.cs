using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            query = System.Uri.EscapeDataString(query);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(readToEnd
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id, string dateTime)
        {
            //station = System.Uri.EscapeDataString(station);
            //id = System.Uri.EscapeDataString(id);
            //dateTime = System.Uri.EscapeDataString(dateTime);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&id=" + id +"&datetime=" + dateTime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStation, string dateTime)
        {
            //fromStation = System.Uri.EscapeDataString(fromStation);
            //toStation = System.Uri.EscapeDataString(toStation);
            //dateTime = System.Uri.EscapeDataString(dateTime);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation + "&datetime=" + dateTime);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                Connections connections = JsonConvert.DeserializeObject<Connections>(readToEnd
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
