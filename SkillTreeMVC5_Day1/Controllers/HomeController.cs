using System.Web.Mvc;
using SkillTreeMVC5_Day1.Services;

namespace SkillTreeMVC5_Day1.Controllers
{
    public class HomeController : Controller
    {
        private readonly LedgerService _ledgerService = new LedgerService();

        public ActionResult Index()
        {
            var result = _ledgerService.GetAll();

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}