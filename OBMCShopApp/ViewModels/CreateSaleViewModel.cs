using System;
using System.Collections.Generic;

namespace OBMCShopApp.ViewModels
{
    public class CreateSaleInputModel
    {
        public CreateSaleInputModel()
        {
            Products = new();
        }
        public decimal SubTotal { get; set; }

        public decimal GrandTotal { get; set; }

        public List<ProductSoldViewModel> Products { get; set; }

        public DateTime SaleDate { get; set; }

        public string SalesPerson { get; set; }
    }

    public class ProductSoldViewModel
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal RetailPrice { get; set; }

        public float Quantity { get; set; }


    }
}