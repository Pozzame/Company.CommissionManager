using Company.CommissionManager.Samples;
using Xunit;

namespace Company.CommissionManager.EntityFrameworkCore.Domains;

[Collection(CommissionManagerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CommissionManagerEntityFrameworkCoreTestModule>
{

}
