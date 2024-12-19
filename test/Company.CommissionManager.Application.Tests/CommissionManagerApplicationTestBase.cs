using Volo.Abp.Modularity;

namespace Company.CommissionManager;

public abstract class CommissionManagerApplicationTestBase<TStartupModule> : CommissionManagerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
