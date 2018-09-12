using ServerHosting.Core.Contracts.Services;
using ServerHosting.WebApi.Mapper;
using ServerHosting.WebApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace ServerHosting.WebApi.Controllers
{
    public class StatusController : ApiController
    {
        private IServerStatusService _serverStatusService;

        public StatusController(IServerStatusService serverStatusService)
        {
            _serverStatusService = serverStatusService;
        }

        // GET api/values
        public IEnumerable<ServerStatusModel> Get()
        {
            return _serverStatusService.Get().ToModel();
        }
    }
}