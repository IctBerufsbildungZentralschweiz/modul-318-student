namespace SwissTransport.Core
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using SwissTransport.Models;

    public class Transport : ITransport, IDisposable
    {
        private const string WebApiHost = "https://transport.opendata.ch/v1/";

        private readonly HttpClient httpClient = new HttpClient();

        public async Task<Stations> GetStationsAsync(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var uri = new Uri($"{WebApiHost}locations?query={query}");
            return await this.GetObjectAsync<Stations>(uri);
        }

        public Stations GetStations(string query) =>
            this.GetStationsAsync(query)
                .GetAwaiter()
                .GetResult();

        public async Task<StationBoardRoot> GetStationBoardAsync(string station, string id)
        {
            if (string.IsNullOrEmpty(station))
            {
                throw new ArgumentNullException(nameof(station));
            }

            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            var uri = new Uri($"{WebApiHost}stationboard?station={station}&id={id}");
            return await this.GetObjectAsync<StationBoardRoot>(uri);
        }

        public StationBoardRoot GetStationBoard(string station, string id) =>
            this.GetStationBoardAsync(station, id)
                .GetAwaiter()
                .GetResult();

        public async Task<Connections> GetConnectionsAsync(string fromStation, string toStation)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}");
            return await this.GetObjectAsync<Connections>(uri);
        }

        public Connections GetConnections(string fromStation, string toStation) =>
            this.GetConnectionsAsync(fromStation, toStation)
                .GetAwaiter()
                .GetResult();

        public void Dispose()
        {
            this.httpClient?.Dispose();
        }

        private async Task<T> GetObjectAsync<T>(Uri uri)
        {
            HttpResponseMessage response = await this.httpClient.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}