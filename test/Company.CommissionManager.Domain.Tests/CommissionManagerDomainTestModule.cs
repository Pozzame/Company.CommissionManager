using Volo.Abp.Modularity;

namespace Company.CommissionManager;

[DependsOn(
    typeof(CommissionManagerDomainModule),
    typeof(CommissionManagerTestBaseModule)
)]
public class CommissionManagerDomainTestModule : AbpModule
{

}
