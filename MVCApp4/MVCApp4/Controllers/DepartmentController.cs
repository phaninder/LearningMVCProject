using MVCApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp4.Controllers
{
    public class DepartmentController : Controller
	{
		Company db = new Company();
		// GET: Department
		public ActionResult ShowDepartments()
        {
			List<Department> departments = db.Department.ToList();
            return View(departments);
        }

		public ActionResult CombinedResult()
		{
			List<CombinedTable> emp = db.Department.Join(db.Employees, d => d.DeptId, e => e.DeptId,
				(d, e) => new CombinedTable()
				{
					EmpId = e.EmpId,
					EmpName = e.EmpName,
					Job = e.Job,
					Salary = e.Salary,
					DeptId = d.DeptId,
					Loc = d.Loc,
					DepName = d.DepName
				}).ToList();
				return View(emp);
		}
    }
}