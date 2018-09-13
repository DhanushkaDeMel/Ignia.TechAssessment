using ServerHosting.Core.Contracts.Services;
using ServerHosting.WebApi.Mapper;
using ServerHosting.WebApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServerHosting.WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StatusController : ApiController
    {
        private IServerStatusService _serverStatusService;

        public StatusController(IServerStatusService serverStatusService)
        {
            _serverStatusService = serverStatusService;
        }

        // GET api/values
        public async Task<IEnumerable<ServerStatusModel>> Get()
        {
            var result = await _serverStatusService.GetAsync();
            return result.ToModel();
        }
    }
}