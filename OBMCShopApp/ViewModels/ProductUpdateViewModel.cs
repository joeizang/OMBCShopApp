using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OBMCShopApp.Models;

namespace OBMCShopApp.ViewModels
{
    public class ProductUpdateViewModel
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Product Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        [Required]
        [Display(Name = "Selling Price")]
        [DataType(DataType.Currency)]
        public decimal RetailPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        [DataType(DataType.Currency)]
        [Display(Name = "Cost Price")]
        public decimal CostPrice { get; set; }

        [Required]
        [Display(Name = "Supply Date")]
        [DataType(DataType.Date)]
        public DateTimeOffset SupplyDate { get; set; }

        [Required]
        public float Quantity { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "Product Brand")]
        public string Brand { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name = "Any Comments")]
        public string Comments { get; set; }
        
        [Required]
        [EnumDataType(typeof(UnitMeasure))]
        [Display(Name = "Unit Measure")]
        public UnitMeasure UnitMeasure { get; set; }

        public IEnumerable<ShelfViewModel> Shelves { get; set; }
        
        public int ShelfId { get; set; }
    }
}