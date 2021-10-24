using System.Linq;
using AutoMapper;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.AutoMapperProfiles
{
    public class SaleProfile : Profile
    {
        public SaleProfile()
        {
            CreateMap<Sale, SalesIndexViewModel>()
                .ForMember(d => d.NumberOfItemsSold, o => 
                    o.MapFrom(src => src.ItemsSold.Count));
            CreateMap<Sale, CreateSaleInputModel>()
                .ForMember(d => d.Products,
                    o => o.MapFrom(
                        s => s.ItemsSold));
        }
    }
}