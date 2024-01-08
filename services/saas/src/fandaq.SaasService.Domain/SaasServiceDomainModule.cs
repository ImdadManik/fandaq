﻿using Volo.Abp.Modularity;
using Volo.Saas;
using Volo.Payment;

namespace fandaq.SaasService;

[DependsOn(
    typeof(SaasServiceDomainSharedModule),
    typeof(SaasDomainModule),
    typeof(AbpPaymentDomainModule)
)]
public class SaasServiceDomainModule : AbpModule
{
}
