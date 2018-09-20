using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp4.Models;

namespace MVCApp4.Controllers
{
	[RoutePrefix("HomeController")]
	public class HomeController : Controller
	{
		[Route("HelloWorld/{value:int?}")]
		public ActionResult About(int value)
		{
			return Content("About:" + value);
		}

		Company db = new Company();
		public ActionResult Index()
		{
			Company db = new Company();
			List<Employee> employees = db.Employees.ToList();
			//List<Employee> employees = db.Employees.Where (temp => temp.Salary> 90000).ToList();
			//List<Employee> employees = db.Employees.OrderByDescending(temp=>temp.EmpName).ToList();
			//List<Employee> employees = db.Employees.ToList().Take(2).ToList();

			//List<Employee> list1 = db.Employees.Where(temp => temp.Job == "Developer" || temp.Job == "Clerk").ToList();
			//List<Employee> list2 = db.Employees.Where(temp => temp.Salary > 300).ToList();

			//List<Employee> employees = list1.Concat(list2).ToList();
			//List<Employee> employees = list1.Union(list2).ToList();
			//List<Employee> employees = list1.Intersect(list2).ToList();
			//List<Employee> employees = list1.Except(list2).ToList();
			return View(employees);
		}

		public ActionResult Salaries()
		{
			List<decimal> employees = db.Employees.Select(temp => temp.Salary).Distinct().ToList();
			return View(employees);
		}

		public ActionResult Grouping()
		{
			var group = db.Employees.GroupBy(temp => temp.Job).ToList();
			return View(group);
		}

		public ActionResult Create()
		{
			//ViewBag.Departments = db.Department.ToList();
			ViewBag.Departments = db.Database.SqlQuery<Department>("getDepartments").ToList();
			return View();
		}

		[HttpPost]
		public ActionResult Create(Employee emp)
		{
			//db.Employees.Add(emp);
			//db.SaveChanges();
			SqlParameter p1 = new SqlParameter("@empid", emp.EmpId);
			SqlParameter p2 = new SqlParameter("@empname", emp.EmpName);
			SqlParameter p3 = new SqlParameter("@salary", emp.Salary);
			SqlParameter p4 = new SqlParameter("@job", emp.Job);
			SqlParameter p5 = new SqlParameter("@deptid", emp.DeptId);

			db.Database.SqlQuery<object>("insertEmployee @empid,@empname,@salary,@job,@deptId", p1, p2, p3, p4, p5).ToList();
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Edit(int id)
		{
			Employee emp = db.Employees.Where(temp => temp.EmpId == id).FirstOrDefault();
			if(emp==null)
			{
				return Content("No employee found");
			}
			else
			{
				ViewBag.Departments = db.Database.SqlQuery<Department>("getDepartments").ToList();//db.Department.ToList();
				return View(emp);
			}
		}
		[HttpPost]
		public ActionResult Edit(int id,Employee emp)
		{
			//Employee e = db.Employees.Where(temp => temp.EmpId == id).FirstOrDefault();
			//e.EmpName = emp.EmpName;
			//e.Job = emp.Job;
			//e.Salary = emp.Salary;
			//e.DeptId = emp.DeptId;
			//db.SaveChanges();
			SqlParameter p1 = new SqlParameter("@empid", id);
			SqlParameter p2 = new SqlParameter("@empname", emp.EmpName);
			SqlParameter p3 = new SqlParameter("@salary", emp.Salary);
			SqlParameter p4 = new SqlParameter("@job", emp.Job);
			SqlParameter p5 = new SqlParameter("@deptid", emp.DeptId);

			db.Database.SqlQuery<object>("updateEmployee @empid,@empname,@salary,@job,@deptId", p1, p2, p3, p4, p5).ToList();

			return RedirectToAction("Index", "Home");
		}

		public ActionResult Delete(int id)
		{
			Employee emp = db.Employees.Where(temp => temp.EmpId == id).FirstOrDefault();
			if(emp==null)
			{
				return Content("No employee found");
			}
			else
			{
				return View(emp);
			}
		}

		[HttpPost]
		public ActionResult Delete(int id,Employee deletedEmp)
		{
			//Employee emp = db.Employees.Where(temp => temp.EmpId == id).FirstOrDefault();
			//db.Employees.Remove(emp);
			//db.SaveChanges();
			SqlParameter p1 = new SqlParameter("@empId",id);
			db.Database.SqlQuery<object>("deleteEmployee @empId", p1).ToList();
			return RedirectToAction("Index", "Home");
		}
    }
}