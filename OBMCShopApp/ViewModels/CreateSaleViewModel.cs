using System;
using System.Collections.Generic;
using OBMCShopApp.Models;

namespace OBMCShopApp.ViewModels
{
    public class CreateSaleInputModel
    {
        public decimal SubTotal { get; set; }

        public decimal GrandTotal { get; set; }

        public List<ProductSoldViewModel> Products { get; set; }

        public DateTimeOffset SaleDate { get; set; }

        public string SalesPerson { get; set; }

        public UnitMeasure UnitMeasure { get; set; }
    }

    public class ProductSoldViewModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public float Quantity { get; set; }
    }
}