using System.Linq;
using System.Web.Mvc;

namespace ANW.ComposerApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Composers = ComposerRepo.Composers;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}