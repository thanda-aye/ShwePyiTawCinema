using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShwePyiTawCinema.Controllers
{
    public class MovieController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewMovie()
        {
            return RedirectToAction("LogIn","Home");
        }

        public IActionResult MovieList()
        {
            return RedirectToAction("LogIn","Home");
        }
    }
}
