using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace TwitterCardTagHelpers.Web.Controllers
{
    public class CardsController : Controller
    {

        public IActionResult Summary()
        {
            return View();
        }

        public IActionResult SummaryLargeImage()
        {
            return View();
        }

        public IActionResult App()
        {
            return View();
        }

        public IActionResult Player()
        {
            return View();
        }
    }
}
