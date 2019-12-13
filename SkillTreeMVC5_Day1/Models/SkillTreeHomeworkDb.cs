namespace SkillTreeMVC5_Day1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SkillTreeHomeworkDb : DbContext
    {
        public SkillTreeHomeworkDb()
            : base("name=SkillTreeHomeworkDb")
        {
        }

        public virtual DbSet<AccountBook> AccountBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
