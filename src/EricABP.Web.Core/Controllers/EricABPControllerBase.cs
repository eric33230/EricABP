using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EricABP.Controllers
{
    public abstract class EricABPControllerBase: AbpController
    {
        protected EricABPControllerBase()
        {
            LocalizationSourceName = EricABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
