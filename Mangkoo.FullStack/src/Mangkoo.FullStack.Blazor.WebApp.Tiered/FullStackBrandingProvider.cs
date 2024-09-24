using Microsoft.Extensions.Localization;
using Mangkoo.FullStack.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Mangkoo.FullStack.Blazor.WebApp.Tiered;

[Dependency(ReplaceServices = true)]
public class FullStackBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FullStackResource> _localizer;

    public FullStackBrandingProvider(IStringLocalizer<FullStackResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
