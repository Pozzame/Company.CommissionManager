using Volo.Abp.Modularity;

namespace Company.CommissionManager;

/* Inherit from this class for your domain layer tests. */
public abstract class CommissionManagerDomainTestBase<TStartupModule> : CommissionManagerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
