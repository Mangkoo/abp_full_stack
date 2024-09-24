using Mangkoo.FullStack.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Mangkoo.FullStack.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class FullStackPageModel : AbpPageModel
{
    protected FullStackPageModel()
    {
        LocalizationResourceType = typeof(FullStackResource);
    }
}
