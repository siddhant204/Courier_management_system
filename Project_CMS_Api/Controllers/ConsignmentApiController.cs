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
    public class ConsignmentApiController : ControllerBase
    {
        private readonly IConsignmentRepository _consignmentRepo;
        public ConsignmentApiController(IConsignmentRepository consignmentRepo)
        {
            _consignmentRepo = consignmentRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Consignment>> GetConsignments()
        {
            return await _consignmentRepo.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Consignment>> GetConsignments(int id)
        {
            return await _consignmentRepo.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Consignment>> PostConsignments([FromBody] Consignment consignment)
        {
            var newConsignment = await _consignmentRepo.Create(consignment);
            return CreatedAtAction(nameof(GetConsignments), new { id = newConsignment.ConsignmentId }, newConsignment);
        }

        [HttpPut]
        public async Task<ActionResult> PutConsignments(int id, [FromBody] Consignment consignment)
        {
            if (id != consignment.ConsignmentId)
            {
                return BadRequest();
            }
            await _consignmentRepo.Update(consignment);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteConsignment(int id)
        {
            var consignmentDelete = await _consignmentRepo.Get(id);
            if (consignmentDelete == null)
            {
                return NotFound();
            }
            await _consignmentRepo.Delete(consignmentDelete.ConsignmentId);
            return NoContent();
        }
    }
}
