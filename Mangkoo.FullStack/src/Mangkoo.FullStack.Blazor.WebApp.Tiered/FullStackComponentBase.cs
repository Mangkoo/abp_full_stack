using Mangkoo.FullStack.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Mangkoo.FullStack.Blazor.WebApp.Tiered;

public abstract class FullStackComponentBase : AbpComponentBase
{
    protected FullStackComponentBase()
    {
        LocalizationResource = typeof(FullStackResource);
    }
}
