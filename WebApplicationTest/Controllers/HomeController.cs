using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            
            return Redirect("Index");
        }
    }
}
