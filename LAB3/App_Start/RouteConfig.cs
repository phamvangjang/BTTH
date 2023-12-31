﻿using System.Web.Mvc;
using System.Web.Routing;

namespace LAB3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "PassingData", action = "ViewDataTest", id = UrlParameter.Optional }
            );
/*
            routes.MapRoute(
                name: "View bag",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "", action = "", id = UrlParameter.Optional }
            );*/
        }
    }
}
