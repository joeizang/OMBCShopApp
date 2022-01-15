using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public interface IProductDataService : IDataService<Product>
    {
        Task<List<ProductIndexViewModel>> GetAllProducts();

        Product UpdateProduct(Product targetProduct, ProductUpdateViewModel updatedModel, IDataService<Product> service);

        Product CreateProduct(ProductCreateInputModel inputModel, IDataService<Product> service);
    }
}