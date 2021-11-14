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
        private readonly IShelfDataService _shelfService;

        public ProductAddedHandler(IDataService<ProductSold> dataService, IShelfDataService shelfService)
        {
            _dataService = dataService;
            _shelfService = shelfService;
        }
        public async Task Handle(ProductAdded notification, CancellationToken cancellationToken)
        {
            if (notification is null)
                throw new ArgumentNullException("ProductAdded Notification is null which is illegal!");
            // save new productsold to db
            try
            {
                var shelfNumber = await _shelfService.GetOne(notification.Product.ShelfId);
                var productJustSold = new ProductSold
                {
                    Price = notification.Product.RetailPrice,
                    Quantity = notification.Product.Quantity,
                    ProductName = notification.Product.Name,
                    ShelfNumber = shelfNumber.ShelfNumber,
                    ProductId = notification.Product.Id
                };
                _dataService.CreateOne(productJustSold);
                await _dataService.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
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
            try
            {
                var productJustSold = new ProductSold
                {
                    Price = notification.Product.RetailPrice,
                    Quantity = notification.Product.Quantity,
                    ProductName = notification.Product.Name,
                    ShelfNumber = notification.Product.ProductShelf.ShelfNumber,
                    ProductId = notification.Product.Id
                };
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
    
    public class ProductDeletedHandler : INotificationHandler<ProductDeleted>
    {
        private readonly IDataService<ProductSold> _service;

        public ProductDeletedHandler(IDataService<ProductSold> service)
        {
            _service = service;
        }
        public async Task Handle(ProductDeleted notification, CancellationToken cancellationToken)
        {
            if (notification is null)
                throw new ArgumentNullException("ProductDeleted Notification is null which is illegal!");
            
            try
            {
                _service.DeleteOne(new ProductSold
                {
                    Id = notification.ProductId
                });
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