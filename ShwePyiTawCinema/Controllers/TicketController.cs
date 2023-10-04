using Microsoft.AspNetCore.Mvc;
using System;
 using System.Collections.Generic;
using System.Linq;
using System.Threading; 

namespace ShwePyiTawCinema.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Ticket()
        {
            //var userName = Session["UserName"];            
            //string username = (string)userName;
            //if (username == "" || username == null)
            //{
            //    return RedirectToAction("LogIn", "Home");
            //}

            return RedirectToAction("LogIn", "Home");
        }

        public IActionResult Edit_Delete()
        {           
            return RedirectToAction("LogIn", "Home");
        }
    }
}
