using Volo.Abp.Data;

namespace Light.Abp.SmsTemplateManagement.EntityFrameworkCore
{
    public static class AbpSmsTemplateManagementDbProperties
    {
        public static string DbTablePrefix { get; set; } = AbpCommonDbProperties.DbTablePrefix;

        public static string DbSchema { get; set; } = AbpCommonDbProperties.DbSchema;

        public const string ConnectionStringName = "AbpSmsTemplateManagement";
    }
}