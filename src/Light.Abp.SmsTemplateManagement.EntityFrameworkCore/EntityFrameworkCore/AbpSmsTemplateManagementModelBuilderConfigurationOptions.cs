using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Light.Abp.SmsTemplateManagement.EntityFrameworkCore
{
    public class AbpSmsTemplateManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AbpSmsTemplateManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(tablePrefix, schema)
        {
        }
    }
}
