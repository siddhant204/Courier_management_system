using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_CMS_Api.Data;
using Project_CMS_Api.Models;

namespace Project_CMS_Api.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        public CustomerRepository(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }
        public async Task<Customer> Create(Customer customer)
        {
            _Db.Customers.Add(customer);
            await _Db.SaveChangesAsync();
            return customer;
        }

        public async Task Delete(int id)
        {
            var customerDelete = await _Db.Customers.FindAsync(id);
            _Db.Customers.Remove(customerDelete);
            await _Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> Get()
        {
            return await _Db.Customers.ToListAsync();
        }

        public async Task<Customer> Get(int id)
        {
            return await _Db.Customers.FindAsync(id);
        }

        public async Task Update(Customer customer)
        {
            _Db.Entry(customer).State = EntityState.Modified;
            await _Db.SaveChangesAsync();
        }
    }
}
