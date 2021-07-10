using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_CMS_Api.Controllers
{
    public class AdminOperationsController : Controller
    {
        public IActionResult Operations()
        {
            return View();
        }

        public IActionResult CustomerList()
        {
            return RedirectToAction("CustomerList", "AdminCustomer");
        }

        public IActionResult AgentList()
        {
            return RedirectToAction("AgentList", "AdminAgent");
        }

        public IActionResult ConsignmentList()
        {
            return RedirectToAction("ConsignmentList", "AdminConsignment");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
