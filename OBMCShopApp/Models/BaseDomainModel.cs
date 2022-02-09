using System;
using System.ComponentModel.DataAnnotations;

namespace OBMCShopApp.Models
{
    public abstract class BaseDomainModel
    {
        public DateOnly CreatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateOnly UpdatedAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}