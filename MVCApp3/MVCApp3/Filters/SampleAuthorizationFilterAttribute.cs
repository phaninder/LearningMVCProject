using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp3.Filters
{
	public class SampleAuthorizationFilterAttribute : FilterAttribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationContext filterContext)
		{
			filterContext.Controller.ViewBag.Message += "From Authorization filter";
		}
	}
}