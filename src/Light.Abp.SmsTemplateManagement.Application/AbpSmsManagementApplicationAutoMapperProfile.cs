using AutoMapper;

namespace Light.Abp.SmsTemplateManagement
{
    public class AbpSmsTemplateManagementApplicationAutoMapperProfile : Profile
    {
        public AbpSmsTemplateManagementApplicationAutoMapperProfile()
        {
            CreateMap<SmsTemplate, SmsTemplateDto>();
            CreateMap<CreateSmsTemplateDto, SmsTemplate>();
            CreateMap<UpdateSmsTemplateDto, SmsTemplate>();

        }
    }
}
