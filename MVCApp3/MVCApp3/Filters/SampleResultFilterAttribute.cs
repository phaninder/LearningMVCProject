using System.Web.Mvc;

namespace MVCApp3.Filters
{
	public class SampleResultFilterAttribute : FilterAttribute, IResultFilter
	{
		public void OnResultExecuted(ResultExecutedContext filterContext)
		{
			filterContext.Controller.ViewBag.Message += "\n Result executed";
		}

		public void OnResultExecuting(ResultExecutingContext filterContext)
		{
			filterContext.Controller.ViewBag.Message += "\n Result executing";
		}
	}
}