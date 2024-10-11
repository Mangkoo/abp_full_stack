using System.Threading.Tasks;
using Mangkoo.FullStack.Localization;
using Mangkoo.FullStack.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Mangkoo.FullStack.Web.Menus;

public class FullStackMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<FullStackResource>();

        context.Menu.Items.InsertRange(
            0, 
            [
                new ApplicationMenuItem(
                    FullStackMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                ),
                new ApplicationMenuItem(
                    FullStackMenus.Merch,
                    l["Menu:Merch"],
                    "~/Merch",
                    icon: "fas fa-shirt",
                    order: 1
                ),
                new ApplicationMenuItem(
                    FullStackMenus.Other,
                    l["Menu:Other"],
                    "~/Other" +
                    "",
                    icon: "fas fa-flask",
                    order: 2
                )
            ]);

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
