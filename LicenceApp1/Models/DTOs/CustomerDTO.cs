using LicenceApp1.Models.Entities;

namespace LicenceApp1.Models.DTOs
{
    public class CustomerDTO
    {
        public int IdCustomer { get; set; }
        public string NameCustomer { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public CustomerDTO() { }
        public CustomerDTO(Customer customer)
        {
            this.IdCustomer = customer.IdCustomer;
            this.NameCustomer = customer.CustomerName;
            this.PhoneNumber = customer.PhoneNumber;
            this.Email = customer.Email;

        }

    }
}
