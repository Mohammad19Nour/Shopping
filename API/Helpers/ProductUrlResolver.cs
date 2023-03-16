using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers

{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _congig;
        public ProductUrlResolver(IConfiguration congig)
        {
            _congig = congig;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _congig["ApiUrl"]+source.PictureUrl;
            }

            return "No Photo";
        }
    }
}