using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Company.CommissionManager.Localization;

namespace Company.CommissionManager.Web;

[Dependency(ReplaceServices = true)]
public class CommissionManagerBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CommissionManagerResource> _localizer;

    public CommissionManagerBrandingProvider(IStringLocalizer<CommissionManagerResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
