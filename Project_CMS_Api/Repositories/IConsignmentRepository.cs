using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Models;

namespace Project_CMS_Api.Repositories
{
    public interface IConsignmentRepository
    {
        Task<IEnumerable<Consignment>> Get();
        Task<Consignment> Get(int id);
        Task<Consignment> Create(Consignment consignment);
        Task Update(Consignment consignment);
        Task Delete(int id);
    }
}
