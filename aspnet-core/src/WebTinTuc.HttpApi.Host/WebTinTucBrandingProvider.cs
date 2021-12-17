using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace WebTinTuc
{
    [Dependency(ReplaceServices = true)]
    public class WebTinTucBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "WebTinTuc";
    }
}
