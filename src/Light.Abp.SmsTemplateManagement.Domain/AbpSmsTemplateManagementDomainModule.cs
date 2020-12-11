using Volo.Abp.Domain;
using Volo.Abp.Modularity;


namespace Light.Abp.SmsTemplateManagement
{
    [DependsOn(
        typeof(AbpSmsTemplateManagementDomainSharedModule),
        typeof(AbpDddDomainModule))]

    public class AbpSmsTemplateManagementDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
