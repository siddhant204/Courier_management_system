using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Models;

namespace Project_CMS_Api.Repositories
{
    public interface IAgentRepository
    {
        Task<IEnumerable<Agent>> Get();
        Task<Agent> Get(int id);
        Task<Agent> Create(Agent agent);
        Task Update(Agent agent);
        Task Delete(int id);
    }
}
