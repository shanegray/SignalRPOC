using System.Web.Mvc;
using System.Web.Routing;

namespace LogMonitor
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Main",
                url: "",
                defaults: new { controller = "Main", action = "Index" }
            );
        }
    }
}