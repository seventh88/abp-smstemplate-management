using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Light.Abp.SmsTemplateManagement
{
    public interface ISmsTemplateRepository : IRepository<SmsTemplate, int>
    {
        Task<SmsTemplate> FindByTemplateCodeAsync(string templateCode);

        Task<SmsTemplate> FindByTypeAsync(string type,bool international);

    }
}