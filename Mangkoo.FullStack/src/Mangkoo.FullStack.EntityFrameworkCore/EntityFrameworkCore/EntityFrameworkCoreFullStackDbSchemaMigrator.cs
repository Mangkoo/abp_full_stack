using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mangkoo.FullStack.Data;
using Volo.Abp.DependencyInjection;

namespace Mangkoo.FullStack.EntityFrameworkCore;

public class EntityFrameworkCoreFullStackDbSchemaMigrator
    : IFullStackDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFullStackDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FullStackDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FullStackDbContext>()
            .Database
            .MigrateAsync();
    }
}
