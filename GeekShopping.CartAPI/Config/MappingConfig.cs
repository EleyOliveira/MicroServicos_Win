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
                c.CreateMap<ProductVO, Product>();
                c.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
