using AutoMapper;
using TikiAPI.Data;
using TikiAPI.DTO;
using TikiAPI.Models;

namespace TikiAPI.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() {
            CreateMap<Account, AccountModel>().ReverseMap();
            CreateMap<Account, AccountDTO>()
                .ForMember(dest => dest.UserCart, opt => opt.MapFrom(src => src.UserCart))
                .ReverseMap();
            CreateMap<UserCart, UserCartDTO>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserCartProducts, opt => opt.MapFrom(src => src.UserCartProducts));
            CreateMap<UserCartProduct, UserCartProductDTO>().ReverseMap()
                .ForMember(dest => dest.UserCartId, opt => opt.MapFrom(src => src.UserCartId))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
        }
    }
}
