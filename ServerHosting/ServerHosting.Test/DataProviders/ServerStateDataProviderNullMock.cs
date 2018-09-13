using ServerHosting.Core.Contracts.DataProviders;
using ServerHosting.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerHosting.Test.DataProviders
{
    public class ServerStateDataProviderNullMock : IServerStateDataProvider
    {
        public async Task<IList<ServerStatus>> GetAsync()
        {
            return null;
        }
    }
}