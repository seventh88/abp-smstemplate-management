using Volo.Abp.Modularity;

namespace Light.Abp.SmsTemplateManagement
{
    [DependsOn(typeof(AbpSmsTemplateManagementDomainSharedModule))]

    public class AbpSmsTemplateManagementApplicationContractsModule : AbpModule
    {

    }
}
