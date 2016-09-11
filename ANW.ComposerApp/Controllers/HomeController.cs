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

        public ActionResult Composer(int id)
        {
            var composer = ComposerRepo.Composers.FirstOrDefault(x => x.Id == id);
            ViewBag.ComposerTitle = composer.Title;
            ViewBag.ComposerName = composer.FirstName + " " + composer.LastName;
            ViewBag.ComposerAwards = composer.Awards;

            return View();
        }
    }
}