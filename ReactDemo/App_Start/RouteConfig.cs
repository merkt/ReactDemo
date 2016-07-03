using System.Web.Mvc;
using System.Web.Routing;

namespace ReactDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Comments", "api/comments", new {controller = "Home", action = "Comments"}
                );

            routes.MapRoute("NewComment", "api/comments/new", new {controller = "Home", action = "AddComment"}
                );

            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}