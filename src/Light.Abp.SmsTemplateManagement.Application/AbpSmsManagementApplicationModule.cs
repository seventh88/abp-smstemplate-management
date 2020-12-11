using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.AutoMapper;
using Volo.Abp.Application;

namespace Light.Abp.SmsTemplateManagement
{
    [DependsOn(
        typeof(AbpSmsTemplateManagementDomainModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpSmsTemplateManagementApplicationContractsModule)
        )]
    public class AbpSmsTemplateManagementApplicationModule : AbpModule
    {

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AbpSmsTemplateManagementApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpSmsTemplateManagementApplicationModule>();
            });
        }
    }
}
