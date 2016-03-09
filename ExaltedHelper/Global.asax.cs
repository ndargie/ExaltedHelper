using ExaltedHelper.DAL;
using ExaltedHelper.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ExaltedHelper
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);        
            Database.SetInitializer<CharmContext>(new CharmInitialiser());
            CharmContext db = new CharmContext();
            db.Database.Initialize(true);
            InitialiseMappers.RegisterMappings();
        }
    }
}
