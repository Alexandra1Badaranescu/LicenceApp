using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using LicenceApp1.Models.Entities;


namespace LicenceApp1.Data
{
    public class LicenceApp1Context : IdentityDbContext<Licence,Customer>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Licence> Licences { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           //one to many
           modelBuilder.Entity<Product>(b =>
            {
                b.HasKey(e => new { e.CustomerId, e.ProductId });
                b.HasOne(e => e.Customer).WithMany(e => e.Products);
                b.HasOne(e => e.Product).WithMany().OnDelete(DeleteBehavior.ClientSetNull);
            });
        modelBuilder.Entity<Licence>(b =>
            {
                b.HasKey(e => new { e.ProductId, e.LicenceId });
                b.HasOne(e => e.Product).WithMany(e => e.Licences);
                b.HasOne(e => e.Licence).WithMany().OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
