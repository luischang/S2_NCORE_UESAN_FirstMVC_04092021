using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2_NCORE_UESAN_FirstMVC.Web.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {          
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "lchangu@esan.edu.pe" && password == "123456")
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
            }

            return RedirectToAction("Login");

        }

    }
}
