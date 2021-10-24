using System.Collections.Generic;
using System.Threading.Tasks;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.Services
{
    public interface ISaleDataService : IDataService<Sale>
    {
        Task<IReadOnlyList<SalesIndexViewModel>> GetAllSales();
    }
}