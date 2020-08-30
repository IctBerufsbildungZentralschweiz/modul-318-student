using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SwissTransport.Extensions;
using SwissTransport.Models;

namespace SwissTransport.Core
{
    public class Transport : ITransport
    {
        private const string WebApiHost = "http://transport.opendata.ch/v1/";
        protected readonly IHttpClient HttpClient = new HttpClient(CredentialCache.DefaultNetworkCredentials, WebRequest.DefaultWebProxy);
        
        public Stations GetStations(string query)
        {
            if(string.IsNullOrEmpty(query))
                throw new ArgumentNullException(nameof(query));

            return GetStationsAsync(query).GetResult();
        }

        public Task<Stations> GetStationsAsync(string query)
        {
            if(string.IsNullOrEmpty(query))
                throw new ArgumentNullException(nameof(query));

            var uri = new Uri($"{WebApiHost}locations?query={query}");
            return HttpClient.GetAsyncObject(uri, JsonConvert.DeserializeObject<Stations>);
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            if(string.IsNullOrEmpty(station))
                throw new ArgumentNullException(nameof(station));
            
            if(string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            return GetStationBoardAsync(station, id).GetResult();
        }

        public Task<StationBoardRoot> GetStationBoardAsync(string station, string id)
        {
            if (string.IsNullOrEmpty(station))
                throw new ArgumentNullException(nameof(station));

            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            var uri = new Uri($"{WebApiHost}stationboard?station={station}&id={id}");
            return HttpClient.GetAsyncObject(uri, JsonConvert.DeserializeObject<StationBoardRoot>);
        }

        public Connections GetConnections(string fromStation, string toStation)
        {
            fromStation = System.Uri.EscapeDataString(fromStation);
            toStation = System.Uri.EscapeDataString(toStation);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
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
