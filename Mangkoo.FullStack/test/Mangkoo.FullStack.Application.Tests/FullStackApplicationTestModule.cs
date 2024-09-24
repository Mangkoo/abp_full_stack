using Volo.Abp.Modularity;

namespace Mangkoo.FullStack;

[DependsOn(
    typeof(FullStackApplicationModule),
    typeof(FullStackDomainTestModule)
)]
public class FullStackApplicationTestModule : AbpModule
{

}
