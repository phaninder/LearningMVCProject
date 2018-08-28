using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PRoject.Models;


namespace MVC_PRoject.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id:" + id);
        }

        public ActionResult Index (int? pageindex,string sortBy)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("PageIndex ={0}&sortBy={1}", pageindex, sortBy));
        }

        [Route("movie/released/{year}/{month:range(1,12):regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(""+year +"/"+month);
        }
    }
}