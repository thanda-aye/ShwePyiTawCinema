using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShwePyiTawCinema.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("LogIn","Home");
        }
    }
}
