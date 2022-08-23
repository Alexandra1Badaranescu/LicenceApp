namespace LicenceApp1.Models.Entities
{
    public class Product
    {
        public int IdProduct { get; set; } 
        public int PriceProduct { get; set; }
        public string ProductName { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Licence> Licences{ get; set; }

    }
}
