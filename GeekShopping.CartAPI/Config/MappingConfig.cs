using AutoMapper;
using GeekShopping.CartAPI.Data.ValueObjects;
using GeekShopping.CartAPI.Model;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        { 
            var mappingConfig = new MapperConfiguration(c =>
            {
                c.CreateMap<ProductVO, Product>().ReverseMap();                
                c.CreateMap<CartDetailVO, CartDetail>().ReverseMap();                
                c.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();                
                c.CreateMap<CartVO, Cart>().ReverseMap();                
            });
            return mappingConfig;
        }
    }
}
