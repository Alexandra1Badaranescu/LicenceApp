using LicenceApp1.Repositories.CustomerRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicenceApp1.Repositories.GenericRepository;
using LicenceApp1.Data;
using LicenceApp1.Models.Entities;

namespace LicenceApp1.Repositories.CustomerRepository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerByName(string name);
        Task<Customer> GetCustomerById(int id);
        Task<Customer> Create();
        Task<Customer> Delete();

    }
}