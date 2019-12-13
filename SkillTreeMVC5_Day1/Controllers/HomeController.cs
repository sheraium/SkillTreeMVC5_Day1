using SkillTreeMVC5_Day1.Services;
using System.Web.Mvc;

namespace SkillTreeMVC5_Day1.Controllers
{
    public class HomeController : Controller
    {
        private readonly LedgerService _ledgerService;

        public HomeController(LedgerService ledgerService)
        {
            _ledgerService = ledgerService;
        }

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