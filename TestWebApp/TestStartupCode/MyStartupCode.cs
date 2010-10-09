﻿using System.Web.Mvc;
using System.Web.Routing;
using WebActivation;

namespace TestWebApp.TestStartupCode {
    public class MyStartupCode : IApplicationStart {
        public void Start() {
            var routes = RouteTable.Routes;

            routes.MapRoute(
                "Foo", // Route name
                "CoolHome", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }
    }
}