﻿using MvcMusicStore.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            System.Data.Entity.Database.SetInitializer(
                new MvcMusicStore.Models.SampleData());
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            
            

        }
    }
}
