using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_CMS_Api.Controllers
{
    public class CustomerOperationsController : Controller
    {
        public IActionResult Operations()
        {
            return View();
        }
        public IActionResult BookConsignment()
        {
            return RedirectToAction("BookConsignment", "Customer");
        }

        public IActionResult SearchConsignment()
        {
            return RedirectToAction("SearchConsignment", "Customer");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
