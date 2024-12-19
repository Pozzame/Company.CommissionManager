using Company.CommissionManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Company.CommissionManager.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CommissionManagerEntityFrameworkCoreModule),
    typeof(CommissionManagerApplicationContractsModule)
)]
public class CommissionManagerDbMigratorModule : AbpModule
{
}
