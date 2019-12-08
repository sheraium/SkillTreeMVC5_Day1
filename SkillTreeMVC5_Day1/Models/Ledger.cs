using System;

namespace SkillTreeMVC5_Day1.Models
{
    public class Ledger
    {
        public LedgerType Type { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
    }

    public enum LedgerType
    {
        Income = 0,
        Expenses = 1,
    }
}