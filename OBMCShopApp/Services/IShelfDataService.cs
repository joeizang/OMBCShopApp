using System.Collections.Generic;
using System.Threading.Tasks;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.Services
{
    public interface IShelfDataService : IDataService<Shelf>
    {
        Task<IReadOnlyList<ShelfViewModel>> GetShelfNumbers();
    }
}