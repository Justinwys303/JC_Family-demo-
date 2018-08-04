using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace JC_Family_demo_
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["init"] = 0;
        }
        protected void Session_End(object sender, EventArgs e)
        {
            if(User.Identity.IsAuthenticated)
            {
                if(HttpContext.Current.Cache.Get(User.Identity.Name) != null)
                {
                    HttpContext.Current.Cache.Remove(User.Identity.Name);
                }
            }
            Session.Abandon();
        }
    }
}
