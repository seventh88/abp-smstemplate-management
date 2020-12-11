using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Light.Abp.SmsTemplateManagement
{
    public class SmsTemplateDto : AuditedEntityDto<int>, IMultiTenant
    {
        public string Type { get; set; }

        public string TemplateCode { get; set; }
       
        public string SignName { get; set; }

        public string Desc { get; set; }

        public string Demo { get; set; }

        public bool International { get;  set; }

        public Guid? TenantId { get; set; }

        public  ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}