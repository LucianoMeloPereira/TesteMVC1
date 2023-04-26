using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TesteMVC1
{ 
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Para funcionar rotas vindas da controller
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "Teste",
            //    url: "sistemas/{controller}/{action}/{id}",
            //    defaults: new { controller = "Teste", action = "IndexTeste", id = UrlParameter.Optional }
            //);

            routes.MapRoute(  
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
