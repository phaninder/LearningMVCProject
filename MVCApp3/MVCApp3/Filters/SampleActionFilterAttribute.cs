using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp3.Filters
{
	public class SampleActionFilterAttribute : FilterAttribute, IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			filterContext.Controller.ViewBag.Message += "\nOn Action Executed";
		}

		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			filterContext.Controller.ViewBag.Message += "\nOn Action Executing";
		}
	}
}