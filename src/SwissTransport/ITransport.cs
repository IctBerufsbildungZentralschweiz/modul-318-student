using System;
using System.Net;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query, string exceptionstring);
        Stations GetStationsByAdresse(string adresse, string exceptionstring);
        StationBoardRoot GetStationBoard(string station, string exceptionstring, string id);
        Connections GetConnections(string fromStation, string toStattion, string exceptionstring);
        StationBoardRoot GetStationBoardWithSpecificTime(string station, DateTime date, string exceptionstring);
        Connections GetConnectionsSpecificTime(string fromStation, string toStation, DateTime date, string exceptionstring, bool IsArrivalTime = false);
    }
}