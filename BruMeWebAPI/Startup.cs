using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;

//[assembly: OwinStartup(typeof(BruMeWebAPI.Startup))]

namespace BruMeWebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "BruMeWebAPI",
                routeTemplate: "BruMeWebAPI/{contoller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }
}
