using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerHosting.Core.Contracts.Services;
using ServerHosting.Core.Services;
using ServerHosting.Test.DataProviders;

namespace ServerHosting.Test
{
    [TestClass]
    public class ServerStatusServiceTest
    {
        [TestMethod]
        public void Success()
        {
            IServerStatusService serverStatusService = new ServerStatusService(new ServerStateDataProviderSucccessMock());
            Assert.AreEqual(serverStatusService.GetAsync().Result.Count, 1);
        }

        [TestMethod]
        public void Empty()
        {
            IServerStatusService serverStatusService = new ServerStatusService(new ServerStateDataProviderNullMock());
            Assert.IsTrue(serverStatusService.GetAsync().Result == null);
        }
    }
}