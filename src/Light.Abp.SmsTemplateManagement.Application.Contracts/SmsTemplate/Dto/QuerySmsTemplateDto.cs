using Volo.Abp.Application.Dtos;

namespace Light.Abp.SmsTemplateManagement
{
    public class QuerySmsTemplateDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}