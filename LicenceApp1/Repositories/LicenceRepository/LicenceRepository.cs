using LicenceApp1.Models;
using LicenceApp1.Models.Entities;
using LicenceApp1.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicenceApp1.Repositories.GenericRepository;
using LicenceApp1.Data;

namespace LicenceApp1.Repositories.LicenceRepository
{
    public class LicenceRepository : GenericRepository<Licence>, ILicenceRepository
    {
        public LicenceRepository(LicenceApp1Context context) : base(context) { }
        public async Task<List<Licence>> GetAllLicences()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Licence> GetLicencesByName(int name)
        {
            return await _context.Licences.FirstOrDefaultAsync(u => u.NameLicence.Equals(name));
        }
        public async Task<Licence> GetLicencessById(int id)
        {
            return await _context.Licences.FirstOrDefaultAsync(u => u.IdLicence.Equals(id));
        }
        public async Task<Licence> GetLicencesByProduct(int id)
        {
            return await _context.Licences
                .Include(u => u.Product)
                    .ThenInclude(ur => ur.ProductName)
                .FirstOrDefaultAsync(u => u.IdLicence.Equals(id));
        }

        public Task<Licence> GetLicencesByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
