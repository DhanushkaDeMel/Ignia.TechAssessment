namespace ServerHosting.WebApi.Models
{
    public class ServerStatusModel
    {
        public string State { get; set; }

        public string IpAddress { get; set; }

        public string HostName { get; set; }
    }
}