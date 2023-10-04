using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShwePyiTawCinema.Controllers
{
    public class ClassTypeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult K15000()
        {
            return RedirectToAction("LogIn", "Home");
        }

        public IActionResult K7500()
        {
            return RedirectToAction("LogIn", "Home");
        }
         
        public IActionResult K6500()
        {
            return RedirectToAction("LogIn", "Home");
        }

        public IActionResult K5500()
        {
            return RedirectToAction("LogIn", "Home");
        }

        public IActionResult K4500()
        {
            return RedirectToAction("LogIn", "Home");
        }

        public IActionResult K3500()
        {
            return RedirectToAction("LogIn", "Home");
        }
    }
}
