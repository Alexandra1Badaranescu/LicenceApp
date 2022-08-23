
using LicenceApp1.Models.Entities;
using LicenceApp1.Repositories;
using LicenceApp1.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicenceApp1.Repositories.CustomerRepository
{
    public interface IUserRepository : IGenericRepository<Customer>
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomersByName(string name);
        Task<Customer> GetCustomersById(int id);
        Task<Customer> Create(Customer customer);
        Task<Customer> Delete(Customer customer);
    }
}
