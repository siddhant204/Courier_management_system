using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Data;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Project_CMS_Api.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace Project_CMS_Api.Controllers
{
    public class AdminConsignmentController : Controller
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        HttpClient client = new HttpClient();
        string url = "https://localhost:44375/api/ConsignmentApi/";
        public AdminConsignmentController(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }

        public async Task<IActionResult> ConsignmentList()
        {
            var consignmentList = JsonConvert.DeserializeObject<List<Consignment>>(await client.GetStringAsync(url)).ToList();
            return View(consignmentList);
        }

        public IActionResult Search(int searching)
        {
            return View(_Db.Consignments.Where(x => x.ConsignmentId.Equals(searching) || searching == 0).ToList());
        }

        public async Task<ActionResult> Edit(int id)
        {
            Consignment con = JsonConvert.DeserializeObject<Consignment>(await client.GetStringAsync(url + id));
            return View(con);
        }

        [HttpPost]
        public async Task<ActionResult> EditConsignment(Consignment cus)
        {
            if (ModelState.IsValid)
            {
                Consignment usr = _Db.Consignments.Find(cus.ConsignmentId);
                usr.ConsignmentBookingDate = cus.ConsignmentBookingDate;
                usr.ConsignmentExpectedDate = cus.ConsignmentExpectedDate;
                usr.ConsignmentStatus = cus.ConsignmentStatus;
                usr.Consignee = cus.Consignee;
                usr.ConsigneeAdd = cus.ConsigneeAdd;
                usr.ConsigneeCode = cus.ConsigneeCode;
                await client.PutAsJsonAsync<Consignment>(url + cus.ConsignmentId, usr);
                return View("ConsignmentList", _Db.Consignments);
            }
            return View(cus);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var consignment = await _Db.Consignments.FindAsync(id);
                if (consignment != null)
                {
                    await client.DeleteAsync(url + id);
                }
                return RedirectToAction("ConsignmentList");

            }
            catch
            {
                return RedirectToAction("ConsignmentList");
            }

        }

        public IActionResult Operations()
        {
            return RedirectToAction("Operations", "AdminOperations");
        }



    }
}
