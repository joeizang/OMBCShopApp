using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OBMCShopApp.Models;
using OBMCShopApp.Services;

namespace OBMCShopApp.Notifications.ProductsNotifications
{
    public class ProductAddedHandler : INotificationHandler<ProductAdded>
    {
        private readonly IDataService<ProductSold> _dataService;

        public ProductAddedHandler(IDataService<ProductSold> dataService)
        {
            _dataService = dataService;
        }
        public async Task Handle(ProductAdded notification, CancellationToken cancellationToken)
        {
            if (notification is null)
                throw new ArgumentNullException("ProductAdded Notification is null which is illegal!");
            // save new productsold to db
            var productJustSold = new ProductSold
            {
                Price = notification.Product.RetailPrice,
                Quantity = notification.Product.Quantity,
                ProductName = notification.Product.Name,
                ShelfNumber = notification.Product.ProductShelf.ShelfNumber,
                ProductId = notification.Product.Id
            };
            _dataService.CreateOne(productJustSold);
            await _dataService.Commit();
        }
    }

    public class ProductUpdatedHandler : INotificationHandler<ProductUpdated>
    {
        private readonly IDataService<ProductSold> _service;

        public ProductUpdatedHandler(IDataService<ProductSold> service)
        {
            _service = service;
        }
        public async Task Handle(ProductUpdated notification, CancellationToken cancellationToken)
        {
            if (notification is null)
                throw new ArgumentNullException("ProductUpdated Notification is null which is illegal!");
            var productJustSold = new ProductSold
            {
                Price = notification.Product.RetailPrice,
                Quantity = notification.Product.Quantity,
                ProductName = notification.Product.Name,
                ShelfNumber = notification.Product.ProductShelf.ShelfNumber,
                ProductId = notification.Product.Id
            };
            try
            {
                _service.CreateOne(productJustSold);
                await _service.Commit().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}