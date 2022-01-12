﻿namespace SwissTransport
{
    using System.Threading.Tasks;
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;
    using System;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public async Task LocationsAsync()
        {
            Stations stations = await this.testee.GetStationsAsync("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public async Task StationBoardAsync()
        {
            StationBoardRoot stationBoard = await this.testee.GetStationBoardAsync("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public void StationBoard()
        {
            StationBoardRoot stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public async Task ConnectionsAsync()
        {
            Connections connections = await this.testee.GetConnectionsAsync("Sursee", "Luzern", Convert.ToDateTime("11:42:22"), Convert.ToDateTime("12.12.2002"));

            connections.Should().NotBeNull();
        }

        [Fact]
        public void Connections()
        {
            Connections connections = this.testee.GetConnections("Sursee", "Luzern", Convert.ToDateTime("12:34:43"), Convert.ToDateTime("24.12.2003"));

            connections.Should().NotBeNull();
        }
    }
}