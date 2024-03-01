using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Pineda.Models;
using System.Diagnostics;

namespace Mission06_Pineda.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;

        public HomeController(MoviesContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KnowJoel()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult AllMovies()
        {
            //var movies = _context.Movies.Include(x => x.Category).ToList();

            //return View("AllMovies", movies);
            //ViewBag.Categories = _context.Categories.ToList();
            //.OrderBy(x => x.Category)

            //return View("AllMovies", new MovieModel());

            var movies = _context.Movies.Include(x => x.Category).ToList(); // This fetches a list of movies
            return View(movies); // Pass the list to the view
        }

        [HttpPost]
        public IActionResult Form(MovieModel blah)
        {
            _context.Movies.Add(blah);
            _context.SaveChanges();
            return View("Confirmation");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
