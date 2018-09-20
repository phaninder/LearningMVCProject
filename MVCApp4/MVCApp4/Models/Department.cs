using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApp4.Models
{
	public class Department
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int DeptId { get; set; }
		public string Loc { get; set; }
		public string DepName { get; set; }
	}
}