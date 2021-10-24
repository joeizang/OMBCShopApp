using System;
using System.ComponentModel.DataAnnotations;

namespace OBMCShopApp.Models
{
    public abstract class BaseDomainModel
    {
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;
        public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow.LocalDateTime;

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}