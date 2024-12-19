using Volo.Abp.Settings;

namespace Company.CommissionManager.Settings;

public class CommissionManagerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CommissionManagerSettings.MySetting1));
    }
}
