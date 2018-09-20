using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp4.Models
{
	public class Company : DbContext
	{
		public Company() : base("data source=localhost\\SQLEXPRESS;user id = sa;password=12345;initial catalog = company")
		{

		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Department> Department { get; set; }
	}
}