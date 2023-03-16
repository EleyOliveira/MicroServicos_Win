using AutoMapper;
using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
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
