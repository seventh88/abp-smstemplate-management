using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Light.Abp.SmsTemplateManagement.Localization;

namespace Light.Abp.SmsTemplateManagement.Permissions
{
    public class AbpSmsTemplateManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpSmsTemplateManagementPermissions.GroupName, L("SmsTemplateManagement"));

            var smsTemplate = myGroup.AddPermission(AbpSmsTemplateManagementPermissions.SmsTemplate.Default, L("Permission:View"));
            smsTemplate.AddChild(AbpSmsTemplateManagementPermissions.SmsTemplate.Create, L("Permission:Create"));
            smsTemplate.AddChild(AbpSmsTemplateManagementPermissions.SmsTemplate.Update, L("Permission:Update"));
            smsTemplate.AddChild(AbpSmsTemplateManagementPermissions.SmsTemplate.Delete, L("Permission:Delete"));
            smsTemplate.AddChild(AbpSmsTemplateManagementPermissions.SmsTemplate.Read, L("Permission:Read"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SmsTemplateManagementResource>(name);
        }
    }
}
