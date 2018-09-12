using ServerHosting.Core.Entities;
using ServerHosting.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace ServerHosting.WebApi.Mapper
{
    public static class EntityMapper
    {
        public static IEnumerable<ServerStatusModel> ToModel(this IEnumerable<ServerStatus> entityList)
        {
            if (entityList == null)
            {
                return null;
            }
            else
            {
                return entityList.Select(e => new ServerStatusModel
                {
                    HostName = e.HostName,
                    IpAddress = e.IpAddress,
                    State = e.State
                }
                ).ToList();
            }
        }
    }
}