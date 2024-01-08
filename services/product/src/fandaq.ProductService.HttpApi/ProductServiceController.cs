using fandaq.ProductService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace fandaq.ProductService;

public abstract class ProductServiceController : AbpController
{
    protected ProductServiceController()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
