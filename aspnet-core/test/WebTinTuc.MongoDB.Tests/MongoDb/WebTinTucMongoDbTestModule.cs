using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace WebTinTuc.MongoDB
{
    [DependsOn(
        typeof(WebTinTucTestBaseModule),
        typeof(WebTinTucMongoDbModule)
        )]
    public class WebTinTucMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = WebTinTucMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
