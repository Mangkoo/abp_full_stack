using Mangkoo.FullStack.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Mangkoo.FullStack.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FullStackEntityFrameworkCoreModule),
    typeof(FullStackApplicationContractsModule)
    )]
public class FullStackDbMigratorModule : AbpModule
{
}
