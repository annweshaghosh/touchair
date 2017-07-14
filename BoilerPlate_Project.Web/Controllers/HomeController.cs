using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace BoilerPlate_Project.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BoilerPlate_ProjectControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}