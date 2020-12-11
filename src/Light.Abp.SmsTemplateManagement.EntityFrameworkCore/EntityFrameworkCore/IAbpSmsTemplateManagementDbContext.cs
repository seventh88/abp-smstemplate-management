using Light.Abp.SmsTemplateManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.SmsTemplateManagement
{
    [ConnectionStringName(AbpSmsTemplateManagementDbProperties.ConnectionStringName)]
    public interface IAbpSmsTemplateManagementDbContext : IEfCoreDbContext
    {
        DbSet<SmsTemplate> SmsTemplates { get; set; }
    }
}
