using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShwePyiTawCinema.Controllers
{
    public class IncomeExpenseController : Controller
    {
           
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DailyIncomeEntry()
        {
            return RedirectToAction("LogIn","Home");
        }
        public IActionResult DailyExpenseEntry()
        {
            return RedirectToAction("LogIn", "Home");
        }
        public IActionResult IncomesByMovie()
        {
            return RedirectToAction("LogIn", "Home");
        }
        public IActionResult ExpenseByMovie()
        {
            return RedirectToAction("LogIn", "Home");
        }
        public IActionResult IncomesByMovieDate_Time()
        {
            return RedirectToAction("LogIn", "Home");
        }
    }
}
