using Mangkoo.FullStack.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mangkoo.FullStack.Permissions;

public class FullStackPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FullStackPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FullStackPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FullStackResource>(name);
    }
}
