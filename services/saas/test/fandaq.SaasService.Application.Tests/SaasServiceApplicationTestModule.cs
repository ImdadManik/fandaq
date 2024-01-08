using fandaq.SaasService.Application;
using Volo.Abp.Modularity;

namespace fandaq.SaasService;

[DependsOn(
    typeof(SaasServiceApplicationModule),
    typeof(SaasServiceDomainTestModule)
    )]
public class SaasServiceApplicationTestModule : AbpModule
{

}
