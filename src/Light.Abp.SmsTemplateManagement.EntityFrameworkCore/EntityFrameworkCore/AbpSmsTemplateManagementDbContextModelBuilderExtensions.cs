using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Light.Abp.SmsTemplateManagement;
using Light.Abp.SmsTemplateManagement.EntityFrameworkCore;

public static class AbpSmsTemplateManagementDbContextModelBuilderExtensions
{
    public static void ConfigureAbpSmsTemplateManagement(
        [NotNull] this ModelBuilder builder,
        Action<AbpSmsTemplateManagementModelBuilderConfigurationOptions> optionsAction = null)
    {
        Check.NotNull(builder, nameof(builder));
        var options = new AbpSmsTemplateManagementModelBuilderConfigurationOptions(
            AbpSmsTemplateManagementDbProperties.DbTablePrefix,
            AbpSmsTemplateManagementDbProperties.DbSchema
        );
        optionsAction?.Invoke(options);

        builder.Entity<SmsTemplate>(b =>
        {
            b.ToTable(options.TablePrefix + "SmsTemplates", options.Schema);
            b.ConfigureAudited();
            b.ConfigureByConvention();
        });
    }
}
