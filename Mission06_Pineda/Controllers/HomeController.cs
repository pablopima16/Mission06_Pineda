using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Pineda.Models;

namespace Mission06_Pineda.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _movieContext;
        public HomeController(MoviesContext temp) 
        {
            _movieContext = temp;
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
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Application response) 
        {
            _movieContext.Movies.Add(response); // Add record to database
            _movieContext.SaveChanges();
            return View("Confirmation", response);
        }

    }
}
