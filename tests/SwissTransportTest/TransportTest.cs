namespace SwissTransport
{
    using System.Threading.Tasks;
    using Core;
    using FluentAssertions;
    using Models;
    using Xunit;

    public class TransportTest
    {
        private readonly ITransport testee;

        public TransportTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public async Task Locations()
        {
            Stations stations = await this.testee.GetStationsAsync("Sursee,");

            stations.StationList.Should().HaveCount(10);
        }

        [Fact]
        public async Task StationBoard()
        {
            StationBoardRoot stationBoard = await this.testee.GetStationBoardAsync("Sursee", "8502007");

            stationBoard.Should().NotBeNull();
        }

        [Fact]
        public async Task Connections()
        {
            Connections connections = await this.testee.GetConnectionsAsync("Sursee", "Luzern");

            connections.Should().NotBeNull();
        }
    }
}