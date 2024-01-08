using Microsoft.Extensions.Hosting;
using Prometheus;
using Volo.Abp;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace fandaq.Shared.Hosting.AspNetCore;

[DependsOn(
    typeof(fandaqSharedHostingModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule)
)]
public class fandaqSharedHostingAspNetCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        if (env.IsDevelopment())
        {
            app.UseMetricServer();
        }
    }
}
