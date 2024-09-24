using Microsoft.AspNetCore.Builder;
using Mangkoo.FullStack;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<FullStackWebTestModule>();

public partial class Program
{
}
