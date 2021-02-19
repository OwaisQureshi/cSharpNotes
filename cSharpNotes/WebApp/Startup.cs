using Microsoft.Owin;
using Owin;

/* Two ways to Add startup.cs
 * 1) When creating a web app, add "Indivual Authentication" and you will have the startup.cs class added
 * 2) Add Startup.cs yourself with an assembly attribute, Configuration method and the Owin and Microsoft.Owin using directive.
 */
//https://stackoverflow.com/questions/45546185/vs-2017-asp-net-mvc-where-is-owin-startup-class
//https://stackoverflow.com/questions/20068075/owin-startup-class-missing

// Using Global.asax (SignalR v1) vs Startup.cs (SignalR v2)
// https://forums.asp.net/t/2041516.aspx?Regarding+Application_Start+Global+asax+cs+and+Startup+cs+used+for+signalr
// https://stackoverflow.com/questions/56660226/how-to-configure-signalr-with-global-asax-instead-of-startup-cs-in-asp-mvc/56660632
// https://forums.asp.net/t/2130412.aspx?Does+SignalR+have+to+start+in+Startup+cs+
// https://docs.microsoft.com/en-us/aspnet/signalr/overview/older-versions/signalr-1x-hubs-api-guide-server

// Understanding Startup.cs
// https://www.codeproject.com/Tips/1069787/Understanding-Startup-cs-file-in-ASP-NET

[assembly: OwinStartupAttribute(typeof(WebApp.Startup))]
namespace WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // EchoConnection is a derived class of PersistentConnection, You create one for Bi-directional communication
            // this will be the server side class for all SignalR functionality
            // "/echo" will be the Signalr End point for the clients
            app.MapSignalR<EchoConnection>("/echo");
        }
    }
}
