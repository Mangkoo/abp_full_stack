using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mangkoo.FullStack.Pages;

public class Index_Tests : FullStackWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
