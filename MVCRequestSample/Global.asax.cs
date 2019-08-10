﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRequestSample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
/*
        protected void Application_PostResolveRequestCache()
        {
            Debugger.Break();
        }

        protected void Application_MapRequestHandler()
        {
            Debugger.Break();
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debugger.Break();
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debugger.Break();
        }
        */
    }
}
