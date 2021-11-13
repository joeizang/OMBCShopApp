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
            if (notification is not null)
            {
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
    }
}