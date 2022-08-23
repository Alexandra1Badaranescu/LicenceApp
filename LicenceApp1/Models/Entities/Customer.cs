namespace LicenceApp1.Models.Entities
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string CustomerName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Product> Products { get; set; }  
    }
}
