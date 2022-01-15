using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public class ProductDataService : GenericDataService<Product>, IProductDataService
    {
        private readonly OBMCShopAppContext _context;

        public ProductDataService(OBMCShopAppContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {
            _context = context;
        }

        public async Task<List<ProductIndexViewModel>> GetAllProducts()
        {
            var products = await _context.Products
                .AsNoTracking()
                .Include(p => p.ProductShelf)
                .Select(p => new ProductIndexViewModel
                {
                    Name = p.Name,
                    SupplyDate = p.SupplyDate,
                    CostPrice = p.CostPrice,
                    RetailPrice = p.RetailPrice,
                    UnitMeasure = p.UnitMeasure,
                    Quantity = p.Quantity,
                    ProductID = p.Id,
                    ShelfNumber = p.ProductShelf.ShelfNumber
                }).ToListAsync().ConfigureAwait(false);
            return products;
        }

        public Product UpdateProduct(Product targetProduct, ProductUpdateViewModel updatedModel,
            IDataService<Product> service)
        {
            try
            {
                targetProduct.Brand = updatedModel.Brand ?? targetProduct.Brand;
                targetProduct.Name = updatedModel.Name ?? targetProduct.Name;
                targetProduct.Comments = updatedModel.Comments ?? targetProduct.Comments;
                targetProduct.CostPrice = updatedModel.CostPrice;
                targetProduct.RetailPrice = updatedModel.RetailPrice;
                targetProduct.UnitMeasure = updatedModel.UnitMeasure;
                targetProduct.ShelfId = updatedModel.ShelfId;
                targetProduct.Quantity = updatedModel.Quantity;

                service.UpdateOne(targetProduct);
                return targetProduct;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Product CreateProduct(ProductCreateInputModel inputModel, IDataService<Product> service)
        {
            try
            {
                var product = new Product
                {
                    Name = inputModel.Name,
                    Brand = inputModel.Brand,
                    CostPrice = inputModel.CostPrice,
                    RetailPrice = inputModel.RetailPrice,
                    Comments = inputModel.Comments,
                    ShelfId = inputModel.ShelfId,
                    Quantity = inputModel.Quantity,
                    SupplyDate = inputModel.SupplyDate,
                    UnitMeasure = inputModel.UnitMeasure
                };
                service.CreateOne(product);
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}