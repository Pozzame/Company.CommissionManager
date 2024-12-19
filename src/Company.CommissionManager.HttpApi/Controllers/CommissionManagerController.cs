using Company.CommissionManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Company.CommissionManager.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CommissionManagerController : AbpControllerBase
{
    protected CommissionManagerController()
    {
        LocalizationResource = typeof(CommissionManagerResource);
    }
}
