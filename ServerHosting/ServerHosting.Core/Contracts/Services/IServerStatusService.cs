using ServerHosting.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerHosting.Core.Contracts.Services
{
    public interface IServerStatusService
    {
        Task<IList<ServerStatus>> GetAsync();
    }
}