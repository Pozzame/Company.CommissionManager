using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Company.CommissionManager.Data;
using Volo.Abp.DependencyInjection;

namespace Company.CommissionManager.EntityFrameworkCore;

public class EntityFrameworkCoreCommissionManagerDbSchemaMigrator
    : ICommissionManagerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCommissionManagerDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CommissionManagerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CommissionManagerDbContext>()
            .Database
            .MigrateAsync();
    }
}
