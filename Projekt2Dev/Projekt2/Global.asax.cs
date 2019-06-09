﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;

namespace Projekt2
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbContext>());
            Database.SetInitializer<DbContext>(null);
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
