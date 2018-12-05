using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult User()
        {
            return View();
        }

        public IActionResult Role()
        {
            return View();
        }

        public IActionResult Procurement()
        {
            return View();
        }
    }
}