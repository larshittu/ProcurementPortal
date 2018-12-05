using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vendor.Controllers
{
    public class BidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BidDeatil()
        {
            return View();
        }

        public IActionResult PassedBids()
        {
            return View();
        }

        public IActionResult PlaceBid()
        {
            return View();
        }

        public IActionResult Buckets()
        {
            return View();
        }

        public IActionResult EditBuckets()
        {
            return View();
        }
    }
}