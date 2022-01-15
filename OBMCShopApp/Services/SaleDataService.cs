using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OBMCShopApp.Data;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OBMCShopApp.Services
{
    public class SaleDataService : GenericDataService<Sale>, ISaleDataService
    {
        private readonly OBMCShopAppContext _context;
        private readonly IMapper _mapper;

        public SaleDataService(OBMCShopAppContext context, IHttpContextAccessor accessor, IMapper mapper) : base(context, accessor)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SalesIndexViewModel>> GetAllSales()
        {
            var query = await _context.Sales.AsNoTracking().Include(s => s.ItemsSold)
                .ProjectTo<SalesIndexViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync()
                .ConfigureAwait(false);
            return query;
        }

        public async Task MakeASale(CreateSaleInputModel inputModel)
        {

        }
    }
}