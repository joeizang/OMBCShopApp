using AutoMapper;
using OBMCShopApp.Models;
using OBMCShopApp.ViewModels;
using System;

namespace OBMCShopApp.AutoMapperProfiles
{
    public class SaleProfile : Profile
    {
        public SaleProfile()
        {
            CreateMap<Sale, SalesIndexViewModel>()
                .ForMember(d => d.NumberOfItemsSold, o =>
                    o.MapFrom(src => src.ItemsSold.Count))
                .ForMember(d => d.SaleDate, o => o.MapFrom(src => src.SaleDate.ToDateTime(TimeOnly.MinValue)));
            CreateMap<Sale, CreateSaleInputModel>()
                .ForMember(d => d.Products,
                    o => o.MapFrom(
                        s => s.ItemsSold));
        }
    }
}