using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ASPMonitorWebApp.Startup))]
namespace ASPMonitorWebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}