using Xunit;

namespace Mangkoo.FullStack.EntityFrameworkCore;

[CollectionDefinition(FullStackTestConsts.CollectionDefinitionName)]
public class FullStackEntityFrameworkCoreCollection : ICollectionFixture<FullStackEntityFrameworkCoreFixture>
{

}
