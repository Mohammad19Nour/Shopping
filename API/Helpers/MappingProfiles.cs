using API.DTOs;
using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Address = Core.Entities.Identity.Address;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Order, OrderToReturnDto>()
                .ForMember(d => d.DeliveryMethod, o =>
                    o.MapFrom(s => s.DeliveryMethod.ShorName))
                .ForMember(d => d.ShippingPrice, o =>
                    o.MapFrom(s => s.DeliveryMethod.Price));
            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(d => d.ProductId, o =>
                    o.MapFrom(s => s.ItemOrdered.ProductItemId))
                .ForMember(d => d.ProductName, o =>
                    o.MapFrom(s => s.ItemOrdered.ProductName))
                .ForMember(d => d.PictureUrl, o =>
                    o.MapFrom(s => s.ItemOrdered.PictureUrl));
            CreateMap<AddressDto, Core.Entities.OrderAggregate.Address>();
            CreateMap<CustomerBasketDto, CustomerBasket>();
            CreateMap<BasketItemDto, BasketItem>();
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(dest => dest.ProductBrand, o => o.MapFrom(src => src.ProductBrand.Name))
                .ForMember(dest => dest.ProductType, o => o.MapFrom(src => src.ProductType.Name))
                .ForMember(dest => dest.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}