using System.Web.Mvc;

namespace MVCApp3.Filters
{
	public class SampleExceptionFilterAttribute : FilterAttribute, IExceptionFilter
	{
		public void OnException(ExceptionContext filterContext)
		{
			filterContext.Controller.ViewBag.Message += "In Exception Filter";
		}
	}
}