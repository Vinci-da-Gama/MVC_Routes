using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routes_Practices
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "TwoParams",
                url: "{controller}/{action}/{param0}/{param1}",
                defaults: new { controller = "TwoParams", action = "Index", param0 = UrlParameter.Optional, param1 = UrlParameter.Optional }
            );

            routes.MapRoute(
                name:"Students",
                url: "{controller}/{id}/{name}/{studentId}",
                defaults: new { controller="Students", action="Index", id=UrlParameter.Optional, name=UrlParameter.Optional, studentId=UrlParameter.Optional },
                constraints: new { id=@"\d+" }
            );
        }
    }
}
