using AutoMapper;
using fandaq.ProductService.Products;

namespace fandaq.ProductService.Web;

public class ProductServiceWebAutoMapperProfile : Profile
{
    public ProductServiceWebAutoMapperProfile()
    {
        CreateMap<ProductDto, ProductUpdateDto>().MapExtraProperties();
    }
}
