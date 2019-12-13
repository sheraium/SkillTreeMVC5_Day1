using System;
using System.Collections.Generic;
using System.Linq;
using SkillTreeMVC5_Day1.Models;
using SkillTreeMVC5_Day1.ViewModels;

namespace SkillTreeMVC5_Day1.Services
{
    public class LedgerService
    {
        public List<MoneyViewModel> GetAll()
        {
            var result = new List<MoneyViewModel>();

            var db = new SkillTreeHomeworkDb();
            var accountBooks = db.AccountBooks.ToList();
            foreach (var book in accountBooks)
            {
                result.Add(new MoneyViewModel()
                {
                    MoneyType = book.Categoryyy.ToString(),
                    Date = book.Dateee,
                    Amount = book.Amounttt,
                });
            }

            return result;
        }
    }
}