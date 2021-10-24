using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OBMCShopApp.Services;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.Controllers
{
    [Authorize(Roles = "SalesPerson,Owner,Admin")]
    public class SalesController : Controller
    {
        private readonly ISaleDataService _service;

        public SalesController(ISaleDataService service)
        {
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
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateSaleInputModel model)
        {
            return View();
        }
    }
}