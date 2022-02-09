using System;
using System.Collections.Generic;

namespace OBMCShopApp.Models
{
    public class Sale : BaseDomainModel
    {
        public Sale()
        {
            ItemsSold = new List<ProductSold>();
        }
        public DateOnly SaleDate { get; set; }

        public string SalesPerson { get; set; } = null!;

        public decimal SubTotal { get; set; }

        public decimal GrandTotal { get; set; }

        public SaleType TypeOfSale { get; set; }

        public PaymentType ModeOfPayment { get; set; }

        public List<ProductSold> ItemsSold { get; set; } //this should be itemSold not product. Product quantities should be updated  when a sale is made.
    }
}