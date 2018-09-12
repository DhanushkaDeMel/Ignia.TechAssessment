using Newtonsoft.Json;

namespace ServerHosting.Core.Entities
{
    public class ServerStatus
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "ip")]
        public string IpAddress { get; set; }

        [JsonProperty(PropertyName = "hostname")]
        public string HostName { get; set; }
    }
}