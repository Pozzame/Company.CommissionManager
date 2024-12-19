using Company.CommissionManager.Samples;
using Xunit;

namespace Company.CommissionManager.EntityFrameworkCore.Applications;

[Collection(CommissionManagerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CommissionManagerEntityFrameworkCoreTestModule>
{

}
