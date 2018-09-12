using ServerHosting.Core.Entities;
using System.Collections.Generic;

namespace ServerHosting.Core.Contracts.DataProviders
{
    public interface IServerStateDataProvider
    {
        IList<ServerStatus> Get();
    }
}