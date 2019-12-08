using SkillTreeMVC5_Day1.Models;

namespace SkillTreeMVC5_Day1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SkillTreeMVC5_Day1.Models.HomeworkModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SkillTreeMVC5_Day1.Models.HomeworkModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var random = new Random(Guid.NewGuid().GetHashCode());
            var now = DateTime.Now;

            foreach (var i in Enumerable.Range(1, 100))
            {
                var date = now.AddDays(i - 100);
                context.Ledgers.AddOrUpdate(new Ledger()
                {
                    Id = i,
                    Type = random.NextDouble() > 0.5 ? LedgerType.Income : LedgerType.Expenses,
                    Timestamp = new DateTime(date.Year, date.Month, date.Day, random.Next(6, 23), random.Next(0, 59),
                        random.Next(0, 59)),
                    Amount = random.Next(1, 1000),
                });
            }

            context.SaveChanges();
        }
    }
}