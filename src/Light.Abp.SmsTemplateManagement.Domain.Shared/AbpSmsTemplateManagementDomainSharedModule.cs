using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Light.Abp.SmsTemplateManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.Validation.Localization;
using Volo.Abp.Validation;

namespace Light.Abp.SmsTemplateManagement
{
    [DependsOn(typeof(AbpValidationModule))]
    public class AbpSmsTemplateManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpSmsTemplateManagementDomainSharedModule>("Light.Abp.SmsTemplateManagement");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<SmsTemplateManagementResource>("en")//默认简体中文
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Resources");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("SmsTemplateManagement", typeof(SmsTemplateManagementResource));
            });
        }
    }
}
