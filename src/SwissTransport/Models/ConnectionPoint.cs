namespace SwissTransport.Models
{
    using System;
    using Newtonsoft.Json;

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public DateTime? Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public DateTime? Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }
    }
}