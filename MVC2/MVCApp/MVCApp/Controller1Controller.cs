using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp
{
	public class Controller1Controller : Controller
	{
		public int Add(int a,int b)
		{
			return a + b;
		}

		public int Square(int a)
		{
			return a * a;
		}
	}
}