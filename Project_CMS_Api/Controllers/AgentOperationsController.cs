using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_CMS_Api.Controllers
{
    public class AgentOperationsController : Controller
    {
        public IActionResult Operations()
        {
            return View();
        }
        public IActionResult ViewConsignment()
        {
            return RedirectToAction("ViewConsignment", "Agent");
        }
        public IActionResult UpdateStatus()
        {
            return RedirectToAction("UpdateStatus", "Agent");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
