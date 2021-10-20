using System.Collections.Generic;

namespace OBMCShopApp.Models
{
    public class Shelf : BaseDomainModel
    {
        public Shelf()
        {
            Products = new List<Product>();
        }

        public string? ShelfNumber { get; set; }

        public string? ShelfDescription { get; set; }

        public List<Product> Products { get; set; }
    }
}