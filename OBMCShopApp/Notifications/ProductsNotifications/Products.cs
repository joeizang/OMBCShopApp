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

    public class ProductUpdated : INotification
    {
        public Product Product { get; set; }

        public string UpdatedBy { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }
    }

    public class ProductDeleted : INotification
    {
        public int ProductId { get; set; }

        public DateTimeOffset DeletedAt { get; set; }
    }
}