namespace SwissTransport.Core
{
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation);
    }
}