using WebTinTuc.MongoDB;
using Xunit;

namespace WebTinTuc
{
    [CollectionDefinition(WebTinTucTestConsts.CollectionDefinitionName)]
    public class WebTinTucApplicationCollection : WebTinTucMongoDbCollectionFixtureBase
    {

    }
}
