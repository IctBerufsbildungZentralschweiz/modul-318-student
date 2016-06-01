namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query, string exceptionstring);
        StationBoardRoot GetStationBoard(string station, string id, string exceptionstring);
        Connections GetConnections(string fromStation, string toStattion, string exceptionstring);
    }
}