using Microsoft.AspNetCore.Http;
using OBMCShopApp.Data;
using OBMCShopApp.Models;

namespace OBMCShopApp.Services
{
    public class SaleDataService : GenericDataService<Sale>, ISaleDataService
    {
        public SaleDataService(OBMCShopAppContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {
        }
    }
}