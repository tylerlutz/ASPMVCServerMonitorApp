using System.Web.Http;
using Microsoft.AspNet.SignalR;
using ASPMonitorWebApp.Hubs;
using ASPMonitorWebApp.Models;


namespace ASPMonitorWebApp.Api
{
    public class ServerInfoController : ApiController
    {
        public void Post(ServerInfoPostData serverInfo)
        {
            var context = GlobalHost.ConnectionManager.GetHubContext("ServerInfo");
            context.Clients.All.cpuInfoMessage(serverInfo.MachineName, serverInfo.Processor, serverInfo.MemUsage, serverInfo.TotalMemory);
        }
    }
}