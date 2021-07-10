using Project_CMS_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project_CMS_Api.Data;
using Microsoft.EntityFrameworkCore;

namespace Project_CMS_Api.Repositories
{
    public class AdminRepository : IAdminRepositories
    {
        private readonly COURIER_MANAGEMENT_SYSTEM_MVCContext _Db;
        public AdminRepository(COURIER_MANAGEMENT_SYSTEM_MVCContext Db)
        {
            _Db = Db;
        }
        public async Task<AdminTable> Create(AdminTable admin)
        {
            _Db.AdminTables.Add(admin);
            await _Db.SaveChangesAsync();
            return admin;
        }

        public async Task Delete(int id)
        {
            var adminDelete = await _Db.AdminTables.FindAsync(id);
            _Db.AdminTables.Remove(adminDelete);
            await _Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<AdminTable>> Get()
        {
            return await _Db.AdminTables.ToListAsync();
        }

        public async Task<AdminTable> Get(int id)
        {
            return await _Db.AdminTables.FindAsync(id);
        }

        public async Task Update(AdminTable admin)
        {
            _Db.Entry(admin).State = EntityState.Modified;
            await _Db.SaveChangesAsync();
        }
    }
}
