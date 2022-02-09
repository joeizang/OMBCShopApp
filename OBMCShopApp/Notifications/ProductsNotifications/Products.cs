using MediatR;
using OBMCShopApp.Models;
using System;

namespace OBMCShopApp.Notifications.ProductsNotifications
{
    public class ProductAdded : INotification
    {
        public Product Product { get; set; }

        public DateOnly AddedWhen { get; set; }

        public string AddedBy { get; set; }
    }

    public class ProductUpdated : INotification
    {
        public Product Product { get; set; }

        public string UpdatedBy { get; set; }

        public DateOnly UpdatedAt { get; set; }
    }

    public class ProductDeleted : INotification
    {
        public int ProductId { get; set; }

        public DateOnly DeletedAt { get; set; }
    }
}