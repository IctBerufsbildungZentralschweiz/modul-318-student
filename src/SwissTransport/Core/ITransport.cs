namespace SwissTransport.Core
{
    using System.Threading.Tasks;

    using global::SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        Task<Stations> GetStationsAsync(string query);

        StationBoardRoot GetStationBoard(string station, string id);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id);

        Connections GetConnections(string fromStation, string toStation);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation);
    }
}