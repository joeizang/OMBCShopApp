using System;
using MediatR;
using OBMCShopApp.Models;

namespace OBMCShopApp.Notifications.ProductsNotifications
{
    public class ProductAdded : INotification
    {
        public Product Product { get; set; }

        public DateTimeOffset AddedWhen { get; set; }

        public string AddedBy { get; set; }
    }
}