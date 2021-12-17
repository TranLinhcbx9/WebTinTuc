using System.Threading.Tasks;

namespace WebTinTuc.Data
{
    public interface IWebTinTucDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
