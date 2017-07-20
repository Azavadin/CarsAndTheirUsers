using CarsAndTheirUsers.Models;
using System;
using System.Data.Entity;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace CarsAndTheirUsers
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(new CarDatabaseInitializer());
        }
    }
}