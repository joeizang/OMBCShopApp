using System;

namespace OBMCShopApp.ViewModels
{
    public class SalesIndexViewModel
    {
        public string SalesPerson { get; set; }

        public decimal GrandTotal { get; set; }

        public DateOnly SaleDate { get; set; }

        public int NumberOfItemsSold { get; set; }
    }
}