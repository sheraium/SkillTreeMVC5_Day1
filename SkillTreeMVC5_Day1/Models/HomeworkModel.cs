namespace SkillTreeMVC5_Day1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HomeworkModel : DbContext
    {
        // Your context has been configured to use a 'HomeworkModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SkillTreeMVC5_Day1.Models.HomeworkModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HomeworkModel' 
        // connection string in the application configuration file.
        public HomeworkModel()
            : base("name=HomeworkModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ledger>().HasKey(a => a.Id);
            modelBuilder.Entity<Ledger>().Property(a => a.Type).IsRequired();
            modelBuilder.Entity<Ledger>().Property(a => a.Timestamp).IsRequired();
            modelBuilder.Entity<Ledger>().Property(a => a.Amount).IsRequired();
            modelBuilder.Entity<Ledger>().Property(a => a.Remark).HasMaxLength(250);

            base.OnModelCreating(modelBuilder);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}