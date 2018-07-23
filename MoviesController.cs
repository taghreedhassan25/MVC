using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModals;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk!" };
            var customer = new List<Customer>
           {
               new Customer { Name="customer1" },
               new Customer {Name="customer2" }

           };

            var ViewModal = new RandomMovieViewModal
            {
                Movie = movie,
                Customers = customer

            };
            return View(ViewModal);
            //return RedirectToAction("Index", "Home", new { page = 1, SortBy = "name" });
        }

        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }


        //public ActionResult ByReleaseDate (int year, int month)
        //{
        //    return Content(year+"/"+month);
        //}

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}