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
    public interface ILicenceRepository
    {
        Task<List<Licence>> GetAllLicences();
        Task<Licence> GetLicencesByName(string name);
        Task<Licence> GetLicencessById(int id);
        Task<Licence> GetLicencesByProduct(int id);

    }
}
