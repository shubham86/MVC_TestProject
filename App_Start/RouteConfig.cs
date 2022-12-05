using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TestProject_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //We need to add this line for attribute routing
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "EmployeeList",
            //    url: "employees",
            //    defaults: new { controller = "Routing", action = "getAllEmployee" }
            //);

            //routes.MapRoute(
            //    name: "EmployeeDetails",
            //    url: "employees/{id}",
            //    defaults: new { controller = "Routing", action = "getEmployee" },
            //    constraints: new { id =@"\d+"}
            //);

            //routes.MapRoute(
            //    name: "EmployeeDepartment",
            //    url: "employees/{id}/dpt",
            //    defaults: new { controller = "Routing", action = "getEmployeeDepartment" },
            //    constraints: new { id = @"\d+" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
