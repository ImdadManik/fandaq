using fandaq.AdministrationService;
using fandaq.AdministrationService.EntityFrameworkCore;
using fandaq.IdentityService;
using fandaq.IdentityService.EntityFrameworkCore;
using fandaq.ProductService;
using fandaq.ProductService.EntityFrameworkCore;
using fandaq.SaasService;
using fandaq.SaasService.EntityFrameworkCore;
using fandaq.Shared.Hosting;
using Volo.Abp.Modularity;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;

namespace fandaq.DbMigrator;

[DependsOn(
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(fandaqSharedHostingModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule),
    typeof(SaasServiceEntityFrameworkCoreModule),
    typeof(SaasServiceApplicationContractsModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceApplicationContractsModule),
    typeof(ProductServiceApplicationContractsModule),
    typeof(ProductServiceEntityFrameworkCoreModule)
)]
public class fandaqDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "fandaq:"; });
    }
}
