using System.Threading.Tasks;
using Bestwise.WJCourt.Configuration.Dto;

namespace Bestwise.WJCourt.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
