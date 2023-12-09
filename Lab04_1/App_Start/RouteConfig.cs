using System.Web.Mvc;
using System.Web.Routing;

namespace Lab04_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "CustomerDetails", id = UrlParameter.Optional }
            );
            
            /*
            // Mặc định, bạn có thể định tuyến tới hành động Index của CustomerController
            routes.MapRoute(
                name: "CustomerController",
                url: "{CustomerController}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
            );
            
            // Định tuyến tới hành động CustomerDetails của CustomerController
            routes.MapRoute(
                name: "CustomerDetails",
                url: "Customer/CustomerDetails",
                defaults: new { controller = "CustomerController", action = "CustomerDetails" }
            );

            // Định tuyến tới hành động CustomerList của CustomerController
            routes.MapRoute(
                name: "CustomerList",
                url: "Product/CustomerList",
                defaults: new { controller = "Customer", action = "CustomerList" }
            );
            */
        }
    }
}
