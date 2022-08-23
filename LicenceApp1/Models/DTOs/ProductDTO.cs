using LicenceApp1.Models.Entities;

namespace LicenceApp1.Models.DTOs
{
    public class ProductDTO
    {
        public int IdProduct { get; set; }
        public virtual Customer IdCustomer { get; set; }
        public int PriceProduct { get; set; }
        public string ProductName { get; set; }
        public ProductDTO() { }
        public ProductDTO(Product product) 
        {
            this.IdProduct=product.IdProduct;
            this.PriceProduct=product.PriceProduct;
            this.ProductName=product.ProductName;
        }
    }
}
