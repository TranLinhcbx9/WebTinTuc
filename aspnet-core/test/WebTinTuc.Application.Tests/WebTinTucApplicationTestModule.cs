using Volo.Abp.Modularity;

namespace WebTinTuc
{
    [DependsOn(
        typeof(WebTinTucApplicationModule),
        typeof(WebTinTucDomainTestModule)
        )]
    public class WebTinTucApplicationTestModule : AbpModule
    {

    }
}