using Xunit;

namespace Company.CommissionManager.EntityFrameworkCore;

[CollectionDefinition(CommissionManagerTestConsts.CollectionDefinitionName)]
public class CommissionManagerEntityFrameworkCoreCollection : ICollectionFixture<CommissionManagerEntityFrameworkCoreFixture>
{

}
