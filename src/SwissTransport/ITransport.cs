﻿namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion, string Date, string Time);
    }
}