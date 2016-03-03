using Microsoft.AspNet.SignalR;

namespace ASPMonitorWebApp.Hubs
{
    public class ServerInfo : Hub
    {
        public void SendServerInfo(string machineName, double processor, int memoryUsage, int totalMemory)
        {
            this.Clients.All.serverInfoMessage(machineName, processor, memoryUsage, totalMemory);
        }
    }
}