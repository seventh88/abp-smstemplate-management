using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Light.Abp.SmsTemplateManagement
{
    public class SmsTemplate : AuditedEntity<int>, IMultiTenant, IHasExtraProperties
    {
        public SmsTemplate()
        {
        }

        /// <summary>
        /// SmsType: Register/ForgotPassword/...
        /// </summary>
        [Required]
        [MaxLength(255)]
        public virtual string Type { get; set; }

        [MaxLength(64)]
        public virtual string TemplateCode { get; set; }

        [Required]
        [MaxLength(64)]
        public virtual string SignName { get; set; }

        [MaxLength(255)]
        public virtual string Desc { get; set; }

        public virtual string Demo { get; set; }

        public virtual bool International { get; set; }

        public virtual Guid? TenantId { get; set; }

        public virtual ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}
