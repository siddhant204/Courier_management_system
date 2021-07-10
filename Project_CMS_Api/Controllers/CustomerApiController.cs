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
    public class CustomerApiController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepo;
        public CustomerApiController(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _customerRepo.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomers(int id)
        {
            return await _customerRepo.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomers([FromBody] Customer customer)
        {
            var newCustomer = await _customerRepo.Create(customer);
            return CreatedAtAction(nameof(GetCustomers), new { id = newCustomer.CustomerId }, newCustomer);
        }

        [HttpPut]
        public async Task<ActionResult> PutCustomers(int id, [FromBody] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }
            await _customerRepo.Update(customer);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            var customerDelete = await _customerRepo.Get(id);
            if (customerDelete == null)
            {
                return NotFound();
            }
            await _customerRepo.Delete(customerDelete.CustomerId);
            return NoContent();
        }
    }
}
