using Volo.Abp.Modularity;

namespace Mangkoo.FullStack;

[DependsOn(
    typeof(FullStackDomainModule),
    typeof(FullStackTestBaseModule)
)]
public class FullStackDomainTestModule : AbpModule
{

}
