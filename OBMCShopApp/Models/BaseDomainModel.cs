using System;
using System.ComponentModel.DataAnnotations;

namespace OBMCShopApp.Models
{
    public abstract class BaseDomainModel
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow.Date;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow.Date;

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}