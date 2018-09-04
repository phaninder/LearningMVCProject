using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApp3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
		{
			FilterConfig.RegisterGlobalFilter(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
