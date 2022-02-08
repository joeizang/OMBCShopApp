using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OBMCShopApp.Models
{
    public class Product : BaseDomainModel
    {
        public Product()
        {

        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(12,2)")]
        [Required]
        public decimal RetailPrice { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal CostPrice { get; set; }

        [Required]
        public DateTime SupplyDate { get; set; }

        [Required]
        public float Quantity { get; set; }

        public string Brand { get; set; }

        public string Comments { get; set; }

        public UnitMeasure UnitMeasure { get; set; }

        public Shelf ProductShelf { get; set; }

        public int ShelfId { get; set; }

    }
}