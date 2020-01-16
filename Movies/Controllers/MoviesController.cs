using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        [Route("movies / released /{year}/{month}")	]       

  public ActionResult MoviesByReleaseDate(int year,int month)
{
            return View();
} 

    }
}