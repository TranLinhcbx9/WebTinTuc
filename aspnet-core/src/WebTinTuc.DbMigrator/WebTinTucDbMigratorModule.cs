using WebTinTuc.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WebTinTuc.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WebTinTucMongoDbModule),
        typeof(WebTinTucApplicationContractsModule)
        )]
    public class WebTinTucDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
