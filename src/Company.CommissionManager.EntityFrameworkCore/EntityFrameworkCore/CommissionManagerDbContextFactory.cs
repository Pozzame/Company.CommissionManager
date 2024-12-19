using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Company.CommissionManager.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class CommissionManagerDbContextFactory : IDesignTimeDbContextFactory<CommissionManagerDbContext>
{
    public CommissionManagerDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        CommissionManagerEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<CommissionManagerDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new CommissionManagerDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Company.CommissionManager.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
