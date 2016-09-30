using System.Web.Mvc;

namespace ProjektPuszcze.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dzialalnosc()
        {
            return View();
        }
        public ActionResult Kontakt()
        {
            return View();
        }
    }
}