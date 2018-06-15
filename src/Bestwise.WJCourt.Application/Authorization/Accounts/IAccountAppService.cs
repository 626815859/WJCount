using System.Threading.Tasks;
using Abp.Application.Services;
using Bestwise.WJCourt.Authorization.Accounts.Dto;

namespace Bestwise.WJCourt.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
