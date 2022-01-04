namespace SwissTransport.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class StationBoardRoot
    {
        [JsonProperty("Station")]
        public Station Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoard> Entries { get; set; }
    }
}