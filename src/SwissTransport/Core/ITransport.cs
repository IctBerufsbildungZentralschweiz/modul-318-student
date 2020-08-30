using System.Threading.Tasks;
using SwissTransport.Models;

namespace SwissTransport.Core
{
    public interface ITransport
    {
        Stations GetStations(string query);
        Task<Stations> GetStationsAsync(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
    }
}