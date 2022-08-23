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

namespace LicenceApp1.Repositories.ProductRepository
{
    public class ProductRepository : GenericRepository<Customer>, IProductRepository
    {
        public ProductRepository(LicenceApp1Context context) : base(context) { }
        public async Task<Product> GetProductsById(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(u => u.IdProduct.Equals(id));
        }
        public async Task<Product> GetByIdWithCustomers(int id)
        {
            return await _context.Products
                .Include(u => u.Customer)
                    .ThenInclude(ur => ur.CustomerName)
                .FirstOrDefaultAsync(u => u.IdProduct.Equals(id));
        }

    }
}
