using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_CMS_Api.Data;
using Project_CMS_Api.Models;

namespace Project_CMS_Api.Repositories
{
    public class ConsignmentRepository : IConsignmentRepository
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        public ConsignmentRepository(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }
        public async Task<Consignment> Create(Consignment consignment)
        {
            _Db.Consignments.Add(consignment);
            await _Db.SaveChangesAsync();
            return consignment;
        }

        public async Task Delete(int id)
        {
            var consignmentDelete = await _Db.Consignments.FindAsync(id);
            _Db.Consignments.Remove(consignmentDelete);
            await _Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Consignment>> Get()
        {
            return await _Db.Consignments.ToListAsync();
        }

        public async Task<Consignment> Get(int id)
        {
            return await _Db.Consignments.FindAsync(id);
        }

        public async Task Update(Consignment consignment)
        {
            _Db.Entry(consignment).State = EntityState.Modified;
            await _Db.SaveChangesAsync();
        }
    }
}
