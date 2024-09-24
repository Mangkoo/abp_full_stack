using Mangkoo.FullStack.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Mangkoo.FullStack.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FullStackController : AbpControllerBase
{
    protected FullStackController()
    {
        LocalizationResource = typeof(FullStackResource);
    }
}
