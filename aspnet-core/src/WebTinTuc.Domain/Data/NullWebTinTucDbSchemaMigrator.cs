using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WebTinTuc.Data
{
    /* This is used if database provider does't define
     * IWebTinTucDbSchemaMigrator implementation.
     */
    public class NullWebTinTucDbSchemaMigrator : IWebTinTucDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}