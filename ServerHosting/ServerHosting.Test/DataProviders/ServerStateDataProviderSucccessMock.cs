using ServerHosting.Core.Contracts.DataProviders;
using ServerHosting.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerHosting.Test.DataProviders
{
    public class ServerStateDataProviderSucccessMock : IServerStateDataProvider
    {
        public async Task<IList<ServerStatus>> GetAsync()
        {
            var result = new List<ServerStatus>();
            result.Add(new ServerStatus { HostName = "x", IpAddress = "x", State = "x" });

            return result;
        }
    }
}