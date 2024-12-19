using Microsoft.AspNetCore.Builder;
using Company.CommissionManager;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Company.CommissionManager.Web.csproj"); 
await builder.RunAbpModuleAsync<CommissionManagerWebTestModule>(applicationName: "Company.CommissionManager.Web");

public partial class Program
{
}
