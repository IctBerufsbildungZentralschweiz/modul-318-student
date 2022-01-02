namespace SwissTransport.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Stations
    {
        [JsonProperty("stations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Station> StationList { get; set; }
    }
}