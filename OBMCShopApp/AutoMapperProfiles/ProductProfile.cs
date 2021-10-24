using AutoMapper;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;

namespace OBMCShopApp.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductIndexViewModel>()
                .ForMember(dest => dest.ProductID,
                    option =>
                        option.MapFrom(src => src.Id))
                .ForMember(dest => dest.ShelfNumber,
                    opt => opt.MapFrom(src =>
                        src.ProductShelf.ShelfNumber));
            CreateMap<Product, ProductUpdateViewModel>()
                .ForMember(d => d.ProductId,
                    o => o.MapFrom(s =>
                        s.Id));
        }
    }
}