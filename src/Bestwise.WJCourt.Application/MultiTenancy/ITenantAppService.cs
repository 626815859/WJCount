using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bestwise.WJCourt.MultiTenancy.Dto;

namespace Bestwise.WJCourt.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
