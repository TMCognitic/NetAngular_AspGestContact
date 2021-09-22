using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspGestContact.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Contact Page";
            ViewData["Year"] = DateTime.Now.Year;
            return View();
        }
    }
}
