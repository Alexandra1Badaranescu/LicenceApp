
using LicenceApp1.Models.Entities;
using LicenceApp1.Repositories;
using LicenceApp1.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicenceApp1.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<Product> GetProductsById(int id);
        Task<Product> GetByIdWithCustomers(int id);
    }
}
