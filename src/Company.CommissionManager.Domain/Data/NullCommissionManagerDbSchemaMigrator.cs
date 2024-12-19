using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Company.CommissionManager.Data;

/* This is used if database provider does't define
 * ICommissionManagerDbSchemaMigrator implementation.
 */
public class NullCommissionManagerDbSchemaMigrator : ICommissionManagerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
