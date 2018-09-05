using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp4.Controllers
{
	[RoutePrefix("HomeController")]
	public class HomeController : Controller
    {
        [Route("HelloWorld/{value:int?}")]
		public ActionResult About(int value)
		{
			return Content("About:"+value);
		}

        public ActionResult Index(int ?a)
        {
            return View();
        }
    }
}