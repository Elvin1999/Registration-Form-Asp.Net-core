using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationProject.Models;

namespace ValidationProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Register",new Register() { Birthdate=DateTime.Now});
        }
        [HttpPost]
        public IActionResult Register(Register model)
        {
            return View("Completed", model);
        }
    }
}