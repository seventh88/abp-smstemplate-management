namespace Light.Abp.SmsTemplateManagement.Permissions
{
    public static class AbpSmsTemplateManagementPermissions
    {
        public const string GroupName = "SmsTemplateManagement";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static class SmsTemplate
        {
            public const string Default = GroupName + ".SmsTemplates";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string Read = Default + ".Read";
        }

    }
}