using SkillTreeMVC5_Day1.Models;
using SkillTreeMVC5_Day1.Services;
using SkillTreeMVC5_Day1.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SkillTreeMVC5_Day1.Controllers
{
    public class HomeController : Controller
    {
        private readonly LedgerService _ledgerService;

        public HomeController()
        {
            _ledgerService = new LedgerService();
        }

        public ActionResult Index()
        {
            var result = new List<MoneyViewModel>();
            //{
            //    new MoneyViewModel() {MoneyType = "支出", Date = DateTime.Now, Amount = 300},
            //    new MoneyViewModel() {MoneyType = "支出", Date = DateTime.Now, Amount = 1600},
            //    new MoneyViewModel() {MoneyType = "支出", Date = DateTime.Now, Amount = 8.01m},
            //};

            foreach (var ledger in _ledgerService.GetAll())
            {
                result.Add(new MoneyViewModel()
                {
                    MoneyType = GetLedgerTypeName(ledger.Type),
                    Date = ledger.Timestamp,
                    Amount = ledger.Amount,
                });
            }

            return View(result);
        }

        private string GetLedgerTypeName(LedgerType ledgerType)
        {
            switch (ledgerType)
            {
                case LedgerType.Income:
                    return "收入";

                case LedgerType.Expenses:
                    return "支出";

                default:
                    throw new ArgumentOutOfRangeException(nameof(ledgerType), ledgerType, null);
            }
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