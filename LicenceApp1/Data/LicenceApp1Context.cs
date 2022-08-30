using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using LicenceApp1.Models.Entities;


namespace LicenceApp1.Data
{
    public class LicenceApp1Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Licence> Licences { get; set; }
       
    }
}
