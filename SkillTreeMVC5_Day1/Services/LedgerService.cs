using SkillTreeMVC5_Day1.Models;
using SkillTreeMVC5_Day1.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SkillTreeMVC5_Day1.Services
{
    public class LedgerService
    {
        public List<MoneyViewModel> GetAll()
        {
            var db = new SkillTreeHomeworkDb();
            var accountBooks = db.AccountBooks.ToList();

            return accountBooks.Select(book =>
                new MoneyViewModel()
                {
                    MoneyType = book.Categoryyy.ToString(),
                    Date = book.Dateee,
                    Amount = book.Amounttt,
                }).ToList();
        }
    }
}