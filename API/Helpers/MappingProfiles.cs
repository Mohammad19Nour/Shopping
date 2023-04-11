using API.DTOs;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Product,ProductToReturnDto>()
            .ForMember(dest=>dest.ProductBrand , o => o.MapFrom(src=>src.ProductBrand.Name))
            .ForMember(dest=>dest.ProductType , o => o.MapFrom(src=>src.ProductType.Name))
            .ForMember(dest=>dest.PictureUrl , o => o.MapFrom<ProductUrlResolver>());
        }
    }
}