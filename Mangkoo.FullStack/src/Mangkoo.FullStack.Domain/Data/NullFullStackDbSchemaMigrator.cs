using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Mangkoo.FullStack.Data;

/* This is used if database provider does't define
 * IFullStackDbSchemaMigrator implementation.
 */
public class NullFullStackDbSchemaMigrator : IFullStackDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
