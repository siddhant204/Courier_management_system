using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_CMS_Api.Data;
using Project_CMS_Api.Models;

namespace Project_CMS_Api.Repositories
{
    public class AgentRepository : IAgentRepository
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        public AgentRepository(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }
        public async Task<Agent> Create(Agent agent)
        {
            _Db.Agents.Add(agent);
            await _Db.SaveChangesAsync();
            return agent;
        }

        public async Task Delete(int id)
        {
            var agentDelete = await _Db.Agents.FindAsync(id);
            _Db.Agents.Remove(agentDelete);
            await _Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Agent>> Get()
        {
            return await _Db.Agents.ToListAsync();
        }

        public async Task<Agent> Get(int id)
        {
            return await _Db.Agents.FindAsync(id);
        }

        public async Task Update(Agent agent)
        {
            _Db.Entry(agent).State = EntityState.Modified;
            await _Db.SaveChangesAsync();
        }
    }
}
