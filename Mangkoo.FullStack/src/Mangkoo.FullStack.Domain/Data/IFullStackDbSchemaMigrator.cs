using System.Threading.Tasks;

namespace Mangkoo.FullStack.Data;

public interface IFullStackDbSchemaMigrator
{
    Task MigrateAsync();
}
