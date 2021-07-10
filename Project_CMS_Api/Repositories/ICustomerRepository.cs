using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Models;

namespace Project_CMS_Api.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> Get();
        Task<Customer> Get(int id);
        Task<Customer> Create(Customer customer);
        Task Update(Customer customer);
        Task Delete(int id);
    }
}
