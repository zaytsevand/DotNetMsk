using System.Web.Http;
using Owin;

namespace DotNetMsk._10.DemoTestProject.Host
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
            );

            appBuilder.UseWebApi(config);
        }
    }
}