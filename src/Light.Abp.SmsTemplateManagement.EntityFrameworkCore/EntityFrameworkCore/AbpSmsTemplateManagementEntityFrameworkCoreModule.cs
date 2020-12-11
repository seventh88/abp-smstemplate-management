using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Light.Abp.SmsTemplateManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpSmsTemplateManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
        )]
    public class AbpSmsTemplateManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpSmsTemplateManagementDbContext>();
        }
    }
}
