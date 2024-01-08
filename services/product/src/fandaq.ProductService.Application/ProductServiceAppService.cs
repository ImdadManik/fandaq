using fandaq.ProductService.Localization;
using Volo.Abp.Application.Services;

namespace fandaq.ProductService;

public abstract class ProductServiceAppService : ApplicationService
{
    protected ProductServiceAppService()
    {
        LocalizationResource = typeof(ProductServiceResource);
        ObjectMapperContext = typeof(ProductServiceApplicationModule);
    }
}
