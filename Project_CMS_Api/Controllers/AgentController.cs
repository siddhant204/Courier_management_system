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
    public class AgentController : Controller
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        HttpClient client = new HttpClient();
        string url = "https://localhost:44375/api/ConsignmentApi/";

        public AgentController(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;

        }
        [HttpGet]
        public async Task<IActionResult> ViewConsignment(int searching)
        {
            var consignmentList = JsonConvert.DeserializeObject<List<Consignment>>(await client.GetStringAsync(url)).ToList().Where(x => x.AssignedAgentId.Equals(searching)).ToList();
            return View(consignmentList);
        }



        public async Task<IActionResult> UpdateStatus(int searching)
        {
            var consignmentList = JsonConvert.DeserializeObject<List<Consignment>>(await client.GetStringAsync(url)).ToList().Where(x => x.AssignedAgentId.Equals(searching)).ToList();
            return View(consignmentList);
        }


        public async Task<IActionResult> Update(int id)
        {
            var con = JsonConvert.DeserializeObject<Consignment>(await client.GetStringAsync(url + id));
            con.ConsignmentStatus = "Delivered";
        
            await client.PutAsJsonAsync<Consignment>(url + id, con);
            return View("UpdateStatus2", con);

        }

        public IActionResult Operations()
        {
            return RedirectToAction("Operations", "AgentOperations");
        }



    }
}
