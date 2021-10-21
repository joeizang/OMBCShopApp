using Microsoft.AspNetCore.Mvc;
using OBMCShopApp.Services;

namespace OBMCShopApp.Controllers
{
    public class SalesController : Controller
    {
        public SalesController(ISaleDataService service)
        {
            
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}