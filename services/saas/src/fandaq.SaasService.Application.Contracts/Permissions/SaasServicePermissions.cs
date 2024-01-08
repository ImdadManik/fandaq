using Volo.Abp.Reflection;

namespace fandaq.SaasService.Permissions;

public class SaasServicePermissions
{
    public const string GroupName = "SaasService";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(SaasServicePermissions));
    }
}
