using SkillTreeMVC5_Day1.Models;
using System.Data.Entity;

namespace SkillTreeMVC5_Day1.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }

        public UnitOfWork()
        {
            Context = new HomeworkModel();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}