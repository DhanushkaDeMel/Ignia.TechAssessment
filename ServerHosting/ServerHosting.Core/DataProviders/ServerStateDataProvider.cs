using ServerHosting.Core.Contracts.DataProviders;
using ServerHosting.Core.Entities;
using System;
using System.Collections.Generic;

namespace ServerHosting.Core.DataProviders
{
    public class ServerStateDataProvider : IServerStateDataProvider
    {
        public IList<ServerStatus> Get()
        {
            throw new NotImplementedException();
        }
    }
}