using System;
using System.Web.Mvc;
using MVCApp3.Filters;

namespace MVCApp3
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilter(GlobalFilterCollection filter)
		{
			filter.Add(new SampleActionFilterAttribute());
			filter.Add(new SampleAuthorizationFilterAttribute());
			filter.Add(new SampleResultFilterAttribute());
			filter.Add(new SampleExceptionFilterAttribute());
		}
	}
}