using SkillTreeMVC5_Day1.Models;
using SkillTreeMVC5_Day1.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SkillTreeMVC5_Day1.Services
{
    public class LedgerService
    {
        private readonly Repository<Ledger> _ledgerRepository;

        public LedgerService(IUnitOfWork unitOfWork)
        {
            _ledgerRepository = new Repository<Ledger>(unitOfWork);
        }

        public IList<Ledger> GetAll()
        {
            return _ledgerRepository.LookupAll().ToList();
        }
    }
}