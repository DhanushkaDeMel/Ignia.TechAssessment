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
        private HttpClient _httpClient;

        public ServerStateDataProvider()
        {
            _httpClient = new HttpClient {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["JsonDataStorgeUrl"].ToString())
            };
        }

        public async Task<IList<ServerStatus>> GetAsync()
        {
            List<ServerStatus> data = null;
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(string.Empty);
                if (response.IsSuccessStatusCode)
                {
                    data = JsonConvert.DeserializeObject<List<ServerStatus>>(
                                await response.Content.ReadAsStringAsync()
                            );
                }
  
                return data;
            }
            catch(Exception ex)
            {
                return data;
            }
        }
    }
}