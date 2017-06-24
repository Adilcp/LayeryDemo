using LayeryDemo.DataModel.Model;
using System.Data.Entity;

namespace LayeryDemo.DataModel
{
    public class SchoolDBContext : DbContext
    {
        // Your context has been configured to use a 'StockExchangeDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LanBackupMonitor.DataModel.LanBackupMonitorContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StockExchangeDBContext' 
        // connection string in the application configuration file.
        public SchoolDBContext()
            : base("name=SchoolDBContext")
        {
            Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>()
                .HasMany(t => t.Students)
                .WithOptional(t => t.Standard);

            modelBuilder.Entity<Standard>()
                .HasMany(t => t.Teachers)
                .WithMany(t => t.Standards);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Subjects)
                .WithMany(t => t.Teachers);
        }
    }
}