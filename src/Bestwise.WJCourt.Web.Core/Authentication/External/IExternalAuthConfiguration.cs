using System.Collections.Generic;

namespace Bestwise.WJCourt.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
