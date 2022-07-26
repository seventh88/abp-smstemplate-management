using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Light.Abp.SmsTemplateManagement.EntityFrameworkCore
{
    public class SmsTemplateRepository : EfCoreRepository<AbpSmsTemplateManagementDbContext, SmsTemplate, int>, ISmsTemplateRepository
    {
        public SmsTemplateRepository(IDbContextProvider<AbpSmsTemplateManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<SmsTemplate> FindByTemplateCodeAsync(string templateCode)
        {
            return await (await GetQueryableAsync()).FirstOrDefaultAsync(x => x.TemplateCode == templateCode);
        }

        public async Task<SmsTemplate> FindByTypeAsync(string type, bool international)
        {
            return await (await GetQueryableAsync()).FirstOrDefaultAsync(x => x.Type == type && x.International == international);
        }
    }
}