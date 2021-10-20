using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.Services
{
    public class ProductDataService : GenericDataService<Product>, IProductDataService
    {
        private readonly OBMCShopAppContext _context;

        public ProductDataService(OBMCShopAppContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<ProductIndexViewModel>> GetAllProducts()
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
            return products.AsReadOnly();
        }
    }
}