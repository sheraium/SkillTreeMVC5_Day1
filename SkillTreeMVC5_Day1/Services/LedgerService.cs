using System.Collections.Generic;
using System.Linq;
using SkillTreeMVC5_Day1.Models;

namespace SkillTreeMVC5_Day1.Services
{
    public class LedgerService
    {
        private readonly HomeworkModel _dbContext;

        public LedgerService()
        {
            _dbContext = new HomeworkModel();
        }

        public IList<Ledger> GetAll()
        {
            return _dbContext.Ledgers.ToList();
        }
    }
}