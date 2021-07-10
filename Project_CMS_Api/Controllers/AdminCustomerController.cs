using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Data;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Project_CMS_Api.Models;
using Newtonsoft.Json;

namespace Project_CMS_Api.Controllers
{
    public class AdminCustomerController : Controller
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        HttpClient client = new HttpClient();
        string url = "https://localhost:44375/api/CustomerApi/";

        public AdminCustomerController(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }

        public async Task<IActionResult> CustomerList()
        {
            var customerList = JsonConvert.DeserializeObject<List<Customer>>(await client.GetStringAsync(url)).ToList();
            return View(customerList);
        }

        [HttpGet]
        public IActionResult Create(Customer obj)
        {
            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.CustomerId == 0)
                    {
                        await client.PostAsJsonAsync<Customer>(url, obj);
                    }
                    return RedirectToAction("CustomerList");
                }
                return View(obj);

            }

            catch
            {
                return RedirectToAction("CustomerList");
            }
        }

        public async Task<ActionResult> Edit(int id)
        {
            Customer u = JsonConvert.DeserializeObject<Customer>(await client.GetStringAsync(url + id));
            return View(u);
        }

        [HttpPost]
        public async Task<ActionResult> EditCustomer(Customer cus)
        {
            if (ModelState.IsValid)
            {
                Customer usr = _Db.Customers.Find(cus.CustomerId);
                usr.CustomerName = cus.CustomerName;
                usr.CustomerContact = cus.CustomerContact;
                usr.CustomerEmail = cus.CustomerEmail;
                usr.CustomerPassword = cus.CustomerPassword;
                await client.PutAsJsonAsync<Customer>(url + cus.CustomerId, usr);
                return View("CustomerList", _Db.Customers);
            } 
            return View(cus);
        }

        public async Task<IActionResult> DeleteCustomer(int id)
        {
            try
            {
                var user = await _Db.Customers.FindAsync(id);
                if (user != null)
                {
                    await client.DeleteAsync(url + id);
                }
                return RedirectToAction("CustomerList");

            }
            catch
            {
                return RedirectToAction("CustomerList");
            }

        }

        public IActionResult Operations()
        {
            return RedirectToAction("Operations", "AdminOperations");
        }
    }
}
