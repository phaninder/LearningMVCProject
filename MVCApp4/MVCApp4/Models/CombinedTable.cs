using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp4.Models
{
	public class CombinedTable
	{
		public int EmpId { get; set; }
		public string EmpName { get; set; }
		public decimal Salary { get; set; }
		public string Job { get; set; }
		public int DeptId { get; set; }
		public string Loc { get; set; }
		public string DepName { get; set; }

	}
}