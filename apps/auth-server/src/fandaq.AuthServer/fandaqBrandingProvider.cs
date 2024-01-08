using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace fandaq.AuthServer;

[Dependency(ReplaceServices = true)]
public class fandaqBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "fandaq";
}
