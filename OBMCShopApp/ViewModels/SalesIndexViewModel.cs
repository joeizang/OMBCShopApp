using System;

namespace OBMCShopApp.ViewModels
{
    public class SalesIndexViewModel
    {
        public string SalesPerson { get; set; }

        public decimal GrandTotal { get; set; }

        public DateTime SaleDate { get; set; }

        public int NumberOfItemsSold { get; set; }
    }
}