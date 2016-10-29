using System.Web.Mvc;

namespace KeDu.BaseServiceOpenPlatform.Web.Controllers
{
    public class HomeController : BaseServiceOpenPlatformControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}