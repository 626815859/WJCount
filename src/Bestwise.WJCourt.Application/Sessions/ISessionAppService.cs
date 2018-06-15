using System.Threading.Tasks;
using Abp.Application.Services;
using Bestwise.WJCourt.Sessions.Dto;

namespace Bestwise.WJCourt.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
