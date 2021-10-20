using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OBMCShopApp.Models;
using OBMCShopApp.QuerySpecifications.Product;
using OBMCShopApp.Services;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductDataService _service;
        private readonly IShelfDataService _dataAccess;

        public ProductsController(IProductDataService service, IShelfDataService shelfDataService)
        {
            _service = service;
            _dataAccess = shelfDataService;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllProducts().ConfigureAwait(false);
            return View(result);
        }

        public async Task<ActionResult> Create()
        {
            var shelves = await _dataAccess.GetShelfNumbers().ConfigureAwait(false);
            var input = new ProductCreateInputModel
            {
                Shelves = shelves
            };
            return View(input);
        }
        
        [HttpPost]
        public async Task<ActionResult> Create(ProductCreateInputModel model)
        {
            var duplicateCheck = await _service.GetOne(new FindProductByNameSpec(model.Name)).ConfigureAwait(false);
            if (!ModelState.IsValid || duplicateCheck is not null)
            {
                ModelState.AddModelError(
                    "Error", "Your submission has errors or You are trying to create a Product that exists already!");
                return View();
            }

            var product = new Product
            {
                Name = model.Name,
                Brand = model.Brand,
                CostPrice = model.CostPrice,
                RetailPrice = model.RetailPrice,
                Comments = model.Comments,
                ShelfId = model.ShelfId,
                Quantity = model.Quantity,
                SupplyDate = model.SupplyDate,
                UnitMeasure = model.UnitMeasure
            };

            try
            {
                _service.CreateOne(product);
                await _service.Commit().ConfigureAwait(false);
                return View("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Server Exception", e.Message);
                return View(model);
            }
        }

        [HttpPost]
        public async Task<ActionResult> UpdateProduct(ProductCreateInputModel model)
        {
            
            return View("Edit");
        }
        
    }
}