using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace VajaEvidenca
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //nova koda !! serializacija po referenci  
            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            //aplikacija b ovedno vračala json in ne xml!
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
