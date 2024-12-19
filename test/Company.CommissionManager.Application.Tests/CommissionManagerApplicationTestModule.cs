using Volo.Abp.Modularity;

namespace Company.CommissionManager;

[DependsOn(
    typeof(CommissionManagerApplicationModule),
    typeof(CommissionManagerDomainTestModule)
)]
public class CommissionManagerApplicationTestModule : AbpModule
{

}
