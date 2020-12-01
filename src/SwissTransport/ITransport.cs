namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, int tolimit);
        Connections GetConnections(string fromStation, string toStattion, int tolimit, string date, string time);
    }
}