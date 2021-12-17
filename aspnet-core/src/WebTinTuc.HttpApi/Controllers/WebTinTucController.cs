using WebTinTuc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WebTinTuc.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WebTinTucController : AbpControllerBase
    {
        protected WebTinTucController()
        {
            LocalizationResource = typeof(WebTinTucResource);
        }
    }
}