using System.ComponentModel.DataAnnotations;

namespace OBMCShopApp.ViewModels
{
    public class ShelfViewModel
    {
        [Display(Name = "Shelf Number")]
        [StringLength(6)]
        [DataType(DataType.Text)]
        public string ShelfNumber { get; set; }

        [Display(Name = "Shelf ID")]
        public int ShelfId { get; set; }
    }
}