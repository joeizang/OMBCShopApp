using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBMCShopApp.Models;

namespace OBMCShopApp.ViewModels
{
    public class ProductIndexViewModel
    {
        public int ProductID { get; set; }
        
        public string Name { get; set; }
        
        public decimal RetailPrice { get; set; }
        
        public decimal CostPrice { get; set; }
        
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTimeOffset SupplyDate { get; set; }
        
        public float Quantity { get; set; }
        
        public UnitMeasure UnitMeasure { get; set; }

        public string ShelfNumber { get; set; }
    }
}