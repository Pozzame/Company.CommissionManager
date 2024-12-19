using Company.CommissionManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Company.CommissionManager.Web.Pages;

public abstract class CommissionManagerPageModel : AbpPageModel
{
    protected CommissionManagerPageModel()
    {
        LocalizationResourceType = typeof(CommissionManagerResource);
    }
}
