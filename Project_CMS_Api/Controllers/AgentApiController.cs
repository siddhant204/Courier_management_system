using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_CMS_Api.Models;
using Project_CMS_Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_CMS_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentApiController : ControllerBase
    {
        private readonly IAgentRepository _agentRepo; 
        public AgentApiController(IAgentRepository agentRepo)
        {
            _agentRepo = agentRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Agent>> GetAgents()
        {
            return await _agentRepo.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Agent>> GetAgents(int id)
        {
            return await _agentRepo.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Agent>> PostAgents([FromBody] Agent agent)
        {
            var newAgent = await _agentRepo.Create(agent);
            return CreatedAtAction(nameof(GetAgents), new { id = newAgent.AgentId }, newAgent);
        }

        [HttpPut]
        public async Task<ActionResult> PutAgents(int id, [FromBody] Agent agent)
        {
            if (id != agent.AgentId)
            {
                return BadRequest(); 
            }
            await _agentRepo.Update(agent);
            return NoContent();
        }
        [HttpDelete("{id}")] 
        public async Task<ActionResult> DeleteAgent(int id)
        {
            var agentDelete = await _agentRepo.Get(id);
            if(agentDelete == null)
            {
                return NotFound();
            }
            await _agentRepo.Delete(agentDelete.AgentId);
            return NoContent();
        }
    }
}
