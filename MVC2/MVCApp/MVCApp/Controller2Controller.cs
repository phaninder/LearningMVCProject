using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVCApp
{
	public class Controller2Controller : Controller
	{
		public string DefaultAction(int? PRODUCTID)
		{
			return "Product ID:"+PRODUCTID;
		}

		public string Action1(string name)
		{
			return "Hello " + name;
		}

	}
}