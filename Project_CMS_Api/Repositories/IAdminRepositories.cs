using Project_CMS_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_CMS_Api.Repositories
{
    public interface IAdminRepositories
    {
        Task<IEnumerable<AdminTable>> Get();
        Task<AdminTable> Get(int id);
        Task<AdminTable> Create(AdminTable admin);
        Task Update(AdminTable admin);
        Task Delete(int id);
    }
}
