using Company.CommissionManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Company.CommissionManager.Permissions;

public class CommissionManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CommissionManagerPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(CommissionManagerPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(CommissionManagerPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(CommissionManagerPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(CommissionManagerPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CommissionManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CommissionManagerResource>(name);
    }
}
