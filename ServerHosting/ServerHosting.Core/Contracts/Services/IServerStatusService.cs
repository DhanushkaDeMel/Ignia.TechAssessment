using ServerHosting.Core.Entities;
using System.Collections.Generic;

namespace ServerHosting.Core.Contracts.Services
{
    public interface IServerStatusService
    {
        IList<ServerStatus> Get();
    }
}