using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP.NET_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Expert",
                url: "Expert",
                defaults: new { controller = "Home", action = "Expert" }
            );
            routes.MapRoute(
                name: "News",
                url: "News",
                defaults: new { controller = "Home", action = "News" }
            );

            routes.MapRoute(
                name: "Knowledge",
                url: "Knowledge",
                defaults: new { controller = "Home", action = "Knowledge" }
            );

            routes.MapRoute(
                name: "Login",
                url: "Login",
                defaults: new { controller = "Member", action = "Login" }
            );

            routes.MapRoute(
                name: "Download",
                url: "Download",
                defaults: new { controller = "Member", action = "Download" }
            );

            routes.MapRoute(
                name: "Register",
                url: "Register",
                defaults: new { controller = "Member", action = "Register" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
