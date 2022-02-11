using OBMCShopApp.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace OBMCShopApp.ViewModels
{
    public class ProductIndexViewModel
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal RetailPrice { get; set; }

        public decimal CostPrice { get; set; }

        public int QuantityBought { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime SupplyDate { get; set; }

        public float Quantity { get; set; }

        public UnitMeasure UnitMeasure { get; set; }

        public string ShelfNumber { get; set; }
    }
}