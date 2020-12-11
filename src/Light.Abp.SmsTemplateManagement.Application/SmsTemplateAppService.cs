using System.Linq;
using Volo.Abp.Application.Services;
using Light.Abp.SmsTemplateManagement.Localization;
using Light.Abp.SmsTemplateManagement.Permissions;

namespace Light.Abp.SmsTemplateManagement
{
    public class SmsTemplateAppService : CrudAppService<SmsTemplate, SmsTemplateDto, int, QuerySmsTemplateDto,
        CreateSmsTemplateDto, UpdateSmsTemplateDto>, ISmsTemplateAppService
    {
        private readonly ISmsTemplateRepository _repository;

        public SmsTemplateAppService(ISmsTemplateRepository repository) : base(repository)
        {
            this._repository = repository;
            LocalizationResource = typeof(SmsTemplateManagementResource);
        }

        protected override string GetPolicyName => AbpSmsTemplateManagementPermissions.SmsTemplate.Read;

        protected override string GetListPolicyName => AbpSmsTemplateManagementPermissions.SmsTemplate.Read;

        protected override string CreatePolicyName => AbpSmsTemplateManagementPermissions.SmsTemplate.Create;

        protected override string UpdatePolicyName => AbpSmsTemplateManagementPermissions.SmsTemplate.Update;

        protected override string DeletePolicyName => AbpSmsTemplateManagementPermissions.SmsTemplate.Delete;


        protected override IQueryable<SmsTemplate> CreateFilteredQuery(QuerySmsTemplateDto input)
        {
            IQueryable<SmsTemplate> queryable = Repository;
            if (!string.IsNullOrWhiteSpace(input.Filter))
            {
                queryable = queryable.Where(x => x.Type.Contains(input.Filter) || x.TemplateCode.Contains(input.Filter) );
            }
            return queryable;
        }
    }
}
