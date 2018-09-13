using ServerHosting.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerHosting.Core.Contracts.DataProviders
{
    public interface IServerStateDataProvider
    {
        Task<IList<ServerStatus>> GetAsync();
    }
}