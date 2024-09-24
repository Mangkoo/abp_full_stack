using Volo.Abp.Modularity;

namespace Mangkoo.FullStack;

public abstract class FullStackApplicationTestBase<TStartupModule> : FullStackTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
