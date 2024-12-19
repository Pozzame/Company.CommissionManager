using System.Threading.Tasks;

namespace Company.CommissionManager.Data;

public interface ICommissionManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
