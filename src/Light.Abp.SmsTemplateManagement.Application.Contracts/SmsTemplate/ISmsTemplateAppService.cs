using Volo.Abp.Application.Services;

namespace Light.Abp.SmsTemplateManagement
{
    public interface ISmsTemplateAppService : ICrudAppService<SmsTemplateDto, int, QuerySmsTemplateDto, CreateSmsTemplateDto, UpdateSmsTemplateDto>
    {
       
    }
}