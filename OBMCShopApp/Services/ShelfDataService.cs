using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public class ShelfDataService : GenericDataService<Shelf>, IShelfDataService
    {
        private readonly OBMCShopAppContext _context;

        public ShelfDataService(OBMCShopAppContext context, IHttpContextAccessor accessor) : base(context, accessor)
        {
            _context = context;
        }

        public async Task<List<ShelfViewModel>> GetShelfNumbers()
        {
            var shelves = await _context.Shelves.AsNoTracking()
                .Select(s => new ShelfViewModel
                {
                    ShelfId = s.Id,
                    ShelfNumber = s.ShelfNumber
                }).ToListAsync().ConfigureAwait(false);
            return shelves;
        }
    }
}