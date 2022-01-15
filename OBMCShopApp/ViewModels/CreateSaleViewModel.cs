using OBMCShopApp.Models;
using System;
using System.Collections.Generic;

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
        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal RetailPrice { get; set; }

        public float Quantity { get; set; }
    }
}