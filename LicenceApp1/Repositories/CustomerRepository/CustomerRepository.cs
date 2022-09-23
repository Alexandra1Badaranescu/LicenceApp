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

namespace LicenceApp1.Repositories.CustomerRepository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(LicenceApp1Context context) : base(context) { }

        public async Task<List<Customer>> GetAllCustomers()
        {
            return await GetAll().ToListAsync();
        }
        public async Task<Customer> GetCustomersByName(int name)
        {
            return await _context.Customers.FirstOrDefaultAsync(u => u.CustomerName.Equals(name));
        }

        public async Task<Customer> GetCustomersById(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(u => u.IdCustomer.Equals(id));
        }

        public void Create(Customer customer)
        {
            _context.Customers.Add(customer);
        }
        public void Delete(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public Task<Customer> GetCustomerByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Create()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Delete()
        {
            throw new NotImplementedException();
        }
    }
}
