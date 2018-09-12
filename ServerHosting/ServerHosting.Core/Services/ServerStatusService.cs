using ServerHosting.Core.Contracts.DataProviders;
using ServerHosting.Core.Contracts.Services;
using ServerHosting.Core.Entities;
using System.Collections.Generic;

namespace ServerHosting.Core.Services
{
    public class ServerStatusService : IServerStatusService
    {
        private IServerStateDataProvider _serverStateDataProvider;

        public ServerStatusService(IServerStateDataProvider serverStateDataProvider)
        {
            _serverStateDataProvider = serverStateDataProvider;
        }

        public IList<ServerStatus> Get()
        {
            return _serverStateDataProvider.Get();
        }
    }
}