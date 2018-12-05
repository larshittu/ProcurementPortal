using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class BidController : Controller
    {
        public IActionResult NewBid()
        {
            return View();
        }

        public IActionResult BidExtension()
        {
            return View();
        }

        public IActionResult CloseBid()
        {
            return View();
        }

        public IActionResult Recommendation()
        {
            return View();
        }

        public IActionResult WonReject()
        {
            return View();
        }
    }
}