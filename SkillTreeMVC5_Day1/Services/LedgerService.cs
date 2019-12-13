using System;
using System.Collections.Generic;
using System.Linq;
using SkillTreeMVC5_Day1.ViewModels;

namespace SkillTreeMVC5_Day1.Services
{
    public class LedgerService
    {
        public List<MoneyViewModel> GetAll()
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

            return result;
        }
    }
}