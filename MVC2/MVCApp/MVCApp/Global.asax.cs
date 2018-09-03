using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Mvc;

namespace MVCApp
{
	public class Global : System.Web.HttpApplication
	{

		protected void Application_Start(object sender, EventArgs e)
		{
			System.Web.Routing.RouteTable.Routes.MapRoute("route1", "{controller}/{action}/{a}/{b}",new { controller="controller2",action="DefaultAction",b=UrlParameter.Optional});
			System.Web.Routing.RouteTable.Routes.MapRoute("Route2", "{Controller}/{action}/{name}");
		}
	}
}