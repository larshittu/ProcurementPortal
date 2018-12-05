using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class ApproverController : Controller
    {
        public IActionResult BidApprove()
        {
            return View();
        }

        public IActionResult AwaitBid()
        {
            return View();
        }
    }
}