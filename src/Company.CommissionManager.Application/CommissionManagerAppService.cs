using Company.CommissionManager.Localization;
using Volo.Abp.Application.Services;

namespace Company.CommissionManager;

/* Inherit your application services from this class.
 */
public abstract class CommissionManagerAppService : ApplicationService
{
    protected CommissionManagerAppService()
    {
        LocalizationResource = typeof(CommissionManagerResource);
    }
}
