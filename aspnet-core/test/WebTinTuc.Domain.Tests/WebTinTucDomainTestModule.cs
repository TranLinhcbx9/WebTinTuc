using WebTinTuc.MongoDB;
using Volo.Abp.Modularity;

namespace WebTinTuc
{
    [DependsOn(
        typeof(WebTinTucMongoDbTestModule)
        )]
    public class WebTinTucDomainTestModule : AbpModule
    {

    }
}