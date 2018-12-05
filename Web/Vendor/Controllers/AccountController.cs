using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendor.ViewModels;

namespace Vendor.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            ViewBag.Header = "Vendor Login";
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(string emailaddress, string password)
        {
            return View();
        }

        public IActionResult Token()
        {
            ViewBag.Header = "Token Validation";
            return View();
        }

        [HttpPost]
        public IActionResult Token(TokenView token)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResendToken(TokenView token)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout(string emailaddress)
        {
            return RedirectToAction("Login");
        }
        
        public IActionResult ForgetPassword()
        {
            ViewBag.Header = "Forget Password";
            return View();
        }

        [HttpPost]
        public IActionResult ForgetPassword(string emailaddress)
        {
            return View();
        }

        public IActionResult Signup()
        {
            ViewBag.Header = "Create an Account";
            return View();
        }

        [HttpPost]
        public IActionResult Signup(string emailaddress)
        {
            return View();
        }

        
        public IActionResult SigupConfirmation()
        {
            ViewBag.Header = "Account Information";
            return View();
        }
    }
}