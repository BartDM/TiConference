using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;
using TiConference.Helper;

namespace TiConference
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute(
            //    name: "station",
            //    url: "station/{id}/{stationName}",
            //    defaults: new { controller = "Home", action = "Detail" },
            //    constraints: new { id = "[A-Z]*_[A-Z]*_[0-9]*" });

            //routes.MapRoute(
            //    name: "stations",
            //    url: "station",
            //    defaults: new { controller = "Home", action = "Index" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapMvcAttributeRoutes();

            //var constraintResolver = new DefaultInlineConstraintResolver();
            //constraintResolver.ConstraintMap.Add("values", typeof(ValuesConstraint));
            //routes.MapMvcAttributeRoutes(constraintResolver);

        }
    }
}
