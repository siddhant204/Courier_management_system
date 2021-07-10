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
    public class AdminAgentController : Controller
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        HttpClient client = new HttpClient();
        string url = "https://localhost:44375/api/AgentApi/";
        public AdminAgentController(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }

        [HttpGet]
        public async Task<IActionResult> AgentList()
        {
            var agentList = JsonConvert.DeserializeObject<List<Agent>>(await client.GetStringAsync(url)).ToList();
            return View(agentList);
        }

        [HttpGet]
        public IActionResult Create(Agent obj)
        {
            return View(obj);
        }


        [HttpPost]
        public async Task<ActionResult> AddAgent(int id,Agent agent)
        {
            if(id != agent.AgentId )
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await client.PostAsJsonAsync<Agent>(url, agent);
                return RedirectToAction("AgentList");
            }
            return View(agent);
        }

       [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            Agent u = JsonConvert.DeserializeObject<Agent>(await client.GetStringAsync(url + id));
            return View(u);
        }

   
        public async Task<ActionResult> EditAgent(int id,Agent agent)
        {
            if (ModelState.IsValid)
            {
                Agent usr = _Db.Agents.Find(agent.AgentId);
                usr.AgentName = agent.AgentName;
                usr.AgentContact = agent.AgentContact;
                usr.AgentEmail = agent.AgentEmail;
                usr.AgentPass = agent.AgentPass;
                usr.AreaStartCode = agent.AreaStartCode;
                usr.AreaEndCode = agent.AreaEndCode;
                await client.PostAsJsonAsync<Agent>(url + agent.AgentId, usr);
                return View("AgentList", _Db.Agents);
            }
            return View(agent);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await _Db.Agents.FindAsync(id);
                if (user != null)
                {
                    await client.DeleteAsync(url + id);
                }
                return RedirectToAction("AgentList");

            }
            catch
            {
                return RedirectToAction("AgentList");
            }

        }

        public IActionResult Operations()
        {
            return RedirectToAction("Operations", "AdminOperations");
        }


    }
}
