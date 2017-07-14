using Abp.Web.Mvc.Views;

namespace BoilerPlate_Project.Web.Views
{
    public abstract class BoilerPlate_ProjectWebViewPageBase : BoilerPlate_ProjectWebViewPageBase<dynamic>
    {

    }

    public abstract class BoilerPlate_ProjectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BoilerPlate_ProjectWebViewPageBase()
        {
            LocalizationSourceName = BoilerPlate_ProjectConsts.LocalizationSourceName;
        }
    }
}