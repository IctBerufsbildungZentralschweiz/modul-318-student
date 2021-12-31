namespace SwissTransport.Models
{
    using System;
    using Newtonsoft.Json;

    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}