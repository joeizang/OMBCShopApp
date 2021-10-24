namespace OBMCShopApp.Models
{
    public class ProductSold : BaseDomainModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public float Quantity { get; set; }

        public string ShelfNumber { get; set; }
    }
}