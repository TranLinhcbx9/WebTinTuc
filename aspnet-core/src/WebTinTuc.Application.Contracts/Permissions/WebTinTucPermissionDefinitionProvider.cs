using WebTinTuc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WebTinTuc.Permissions
{
    public class WebTinTucPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WebTinTucPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(WebTinTucPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WebTinTucResource>(name);
        }
    }
}
