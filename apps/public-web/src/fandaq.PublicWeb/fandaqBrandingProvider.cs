using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace fandaq.PublicWeb;

[Dependency(ReplaceServices = true)]
public class fandaqBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "fandaq";
}
