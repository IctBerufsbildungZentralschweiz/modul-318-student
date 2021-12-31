namespace SwissTransport.Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; }
    }
}