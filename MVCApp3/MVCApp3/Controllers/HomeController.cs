using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp3.Models;

namespace MVCApp3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			Employee emp = new Employee()
			{
				EmployeeId = 123,
				EmpName = "P",
				Salary = 200000
			};
			ControllerContext.HttpContext.Cache.Insert("emp", emp, null, DateTime.Now.AddMinutes(2), TimeSpan.Zero);
			//ViewData["Emp"] = emp;
			//ViewBag.Emp = emp;
			return View();
        }
		
		public ActionResult About()
		{
			Employee e = (Employee)ControllerContext.HttpContext.Cache["emp"];
			ViewBag.Emp = e;
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}
    }
}