using System;
using System.Collections.Generic;
using System.Text;
using Mangkoo.FullStack.Localization;
using Volo.Abp.Application.Services;

namespace Mangkoo.FullStack;

/* Inherit your application services from this class.
 */
public abstract class FullStackAppService : ApplicationService
{
    protected FullStackAppService()
    {
        LocalizationResource = typeof(FullStackResource);
    }
}
