using Microsoft.AspNetCore.Mvc;
using OBMCShopApp.Models;
using OBMCShopApp.Services;
using OBMCShopApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBMCShopApp.Controllers
{
    //[Authorize(Roles = "SalesPerson,Owner,Admin")]
    public class SalesController : Controller
    {
        private readonly IDataService<Product> _productService;
        private readonly ISaleDataService _service;

        public SalesController(ISaleDataService service, IDataService<Product> productService)
        {
            _productService = productService;
            _service = service;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var result = await _service.GetAllSales().ConfigureAwait(false);
            return View(result);
        }

        [HttpGet("sales/make-sale")]
        public async Task<ActionResult> Create()
        {
            var products = await _productService.GetAll().ConfigureAwait(false);
            if (!products.Any())
            {
                products = new List<Product>();
            }

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateSaleInputModel model)
        {
            return View();
        }
    }
}