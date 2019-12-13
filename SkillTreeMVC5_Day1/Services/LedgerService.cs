using SkillTreeMVC5_Day1.Models;
using SkillTreeMVC5_Day1.ViewModels;
using System.Collections.Generic;
using System.Linq;
using SkillTreeMVC5_Day1.Repository;

namespace SkillTreeMVC5_Day1.Services
{
    public class LedgerService
    {
        private Repository<AccountBook> _accountBookRepository;

        public LedgerService()
        {
            var unitOfWork = new UnitOfWork();
            _accountBookRepository = new Repository<AccountBook>(unitOfWork);
        }
        public List<MoneyViewModel> GetAll()
        {
            var accountBooks = _accountBookRepository.LookupAll().ToList();

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