using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movieList = GetMovies();

            return View(movieList);
        }

        [Route("movies/release/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult Release(int year, int month)
        {

            return Content(String.Format("Year : {0} <br> Month : {1}", year, month));
        }

        public ActionResult Details(int id)
        {

            var movies = GetMovies();
            var movie = movies.SingleOrDefault(m => m.Id == id);

            if(movie == null)
            {
                return HttpNotFound();
            }
            

            return View(movie);
        }

        //Get Movies
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Id=1, Name="Shrek"},
                new Movie(){Id=2, Name="Killer Ellite"},
                new Movie(){Id=3, Name="Superman"},
            };
        }
    }
}