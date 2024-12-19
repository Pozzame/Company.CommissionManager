using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Company.CommissionManager.Pages;

[Collection(CommissionManagerTestConsts.CollectionDefinitionName)]
public class Index_Tests : CommissionManagerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
