using System;
using System.ComponentModel.DataAnnotations;

namespace Light.Abp.SmsTemplateManagement
{
    public class CreateSmsTemplateDto
    {
      

        [Required]
        [MaxLength(255)]
        public string Type { get; set; }

        [Required]
        public string TemplateCode { get; set; }

        [Required]
        public string SignName { get; set; }

        public string Desc { get; set; }

        public string Demo { get; set; }

        public bool International { get; set; }

        public Guid? TenantId { get; set; }

    }
}