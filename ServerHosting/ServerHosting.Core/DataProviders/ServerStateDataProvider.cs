using Newtonsoft.Json;
using ServerHosting.Core.Contracts.DataProviders;
using ServerHosting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServerHosting.Core.DataProviders
{
    public class ServerStateDataProvider : IServerStateDataProvider
    {
        public HttpClient JsonClient { get; set; }

        public ServerStateDataProvider()
        {
            if (JsonClient == null)
            {
                JsonClient = new HttpClient();
            }

            JsonClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["JsonDataStorgeUrl"].ToString());
        }

        public async Task<IList<ServerStatus>> GetAsync()
        {
            var response = JsonClient.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<ServerStatus>>(responseBody);
                return data;
            }

            return null;
        }
    }
}