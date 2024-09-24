using Volo.Abp.Settings;

namespace Mangkoo.FullStack.Settings;

public class FullStackSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FullStackSettings.MySetting1));
    }
}
