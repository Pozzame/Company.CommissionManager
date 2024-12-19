using Company.CommissionManager.Books;
using Xunit;

namespace Company.CommissionManager.EntityFrameworkCore.Applications.Books;

[Collection(CommissionManagerTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<CommissionManagerEntityFrameworkCoreTestModule>
{

}