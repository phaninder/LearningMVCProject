using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApp4.Models
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int EmpId { get; set; }
		public string EmpName { get; set; }
		public decimal Salary { get; set; }
		public string Job { get; set; }
		public int DeptId { get; set; }

		[ForeignKey("DeptId")]
		public virtual Department Dept { get; set; }
	}
	
}