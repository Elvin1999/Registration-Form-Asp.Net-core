using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (string.IsNullOrEmpty(model.Username))
            {
                ModelState.AddModelError(nameof(model.Username), "Username required");
            }
            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email), "Email is required");
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(model.Email);
                if (!match.Success)
                {
                    ModelState.AddModelError(nameof(model.Email), "Email is not correct format");
                }
            }
            if (string.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError(nameof(model.Password), "Password is required");
            }
            else
            {

                if (model.Password.Length < 6)
                {
                    ModelState.AddModelError(nameof(model.Password), "Password's character count must be greater than 6 characters");
                }
            }
            
            if (!model.TermsAccepted)
            {
                ModelState.AddModelError(nameof(model.TermsAccepted), "You have to accept all terms");
            }
            if (ModelState.IsValid)
            {

                return View("Completed", model);
            }
            else
            {
                return View(model);
            }
        }
    }
}