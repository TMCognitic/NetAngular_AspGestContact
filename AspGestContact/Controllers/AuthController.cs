using AspGestContact.Models.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspGestContact.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {            
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            ViewBag.Title = "Login Page";
            ViewData["Year"] = DateTime.Now.Year;
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginForm form)
        {
            ViewBag.Title = "Login Page";
            ViewData["Year"] = DateTime.Now.Year;
            
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            return RedirectToAction("Index", "Contact");
        }

        public IActionResult Register()
        {
            ViewBag.Title = "Register Page";
            ViewData["Year"] = DateTime.Now.Year;
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterForm form)
        {
            ViewBag.Title = "Register Page";
            ViewData["Year"] = DateTime.Now.Year;

            if(!ModelState.IsValid)
            {
                return View(form);
            }

            return RedirectToAction("Login");
        }
    }
}
