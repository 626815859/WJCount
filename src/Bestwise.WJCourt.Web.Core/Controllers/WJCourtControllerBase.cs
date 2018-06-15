using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Bestwise.WJCourt.Controllers
{
    public abstract class WJCourtControllerBase: AbpController
    {
        protected WJCourtControllerBase()
        {
            LocalizationSourceName = WJCourtConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
