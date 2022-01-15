using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public interface IShelfDataService : IDataService<Shelf>
    {
        Task<List<ShelfViewModel>> GetShelfNumbers();
    }
}