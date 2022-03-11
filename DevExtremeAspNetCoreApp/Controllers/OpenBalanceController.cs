using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinaceBilling.Controllers
{
    public class OpenBalanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OpenBalStatus()
        {
            return View();
        }
    }
}
