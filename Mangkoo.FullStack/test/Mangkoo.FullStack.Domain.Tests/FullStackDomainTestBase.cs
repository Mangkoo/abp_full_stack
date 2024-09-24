using Volo.Abp.Modularity;

namespace Mangkoo.FullStack;

/* Inherit from this class for your domain layer tests. */
public abstract class FullStackDomainTestBase<TStartupModule> : FullStackTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
