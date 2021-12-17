using System;
using System.Collections.Generic;
using System.Text;
using WebTinTuc.Localization;
using Volo.Abp.Application.Services;

namespace WebTinTuc
{
    /* Inherit your application services from this class.
     */
    public abstract class WebTinTucAppService : ApplicationService
    {
        protected WebTinTucAppService()
        {
            LocalizationResource = typeof(WebTinTucResource);
        }
    }
}
