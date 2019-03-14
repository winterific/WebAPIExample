using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPIExample.App_Start
{
    public class MyWebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            config.Routes.MapHttpRoute(
                name: "MyDefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller="My", id = RouteParameter.Optional }
            );
        }
    }
}