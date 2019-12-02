using SkillTreeMVC5_Day1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SkillTreeMVC5_Day1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var result = new List<MoneyViewModel>();
            //{
            //    new MoneyViewModel() {MoneyType = "支出", Date = DateTime.Now, Amount = 300},
            //    new MoneyViewModel() {MoneyType = "支出", Date = DateTime.Now, Amount = 1600},
            //    new MoneyViewModel() {MoneyType = "支出", Date = DateTime.Now, Amount = 8.01m},
            //};

            var random = new Random(Guid.NewGuid().GetHashCode());

            foreach (var i in Enumerable.Range(1, 100))
            {
                result.Add(new MoneyViewModel()
                {
                    MoneyType = random.NextDouble() > 0.5 ? "支出" : "收入",
                    Date = DateTime.Now.AddDays(-100 + i),
                    Amount = random.Next(1, 1000) * 10
                });
            }

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