using smcs.backend.data.access;
using smcs.backend.data.model;
using smcs.backend.data.model.basic;
using smcs.backend.data.model.iterative;
using System.Data.Entity;

namespace smcs.backend.data
{
    internal class SmcsContext : DbContext
    {
        public DbSet<Absence> Absence { get; set; }
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Mission> Mission { get; set; }
        public DbSet<OffDay> OffDay { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<OnDuty> OnDuty { get; set; }
        public DbSet<Rank> Rank { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Signature> Signature { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<UndTreat> UndTreat { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<User> User { get; set; }

        internal SmcsContext(string conStr) : base(conStr)
        {
            if(!Database.Exists())
            {
                this.Configuration.AutoDetectChangesEnabled = false;
                this.Database.Create();
                new access.DbSupplier(this).SeedDbWithInitalData();
                SqlProvider.ExecuteNonQuery("ALTER DATABASE " + this.Database.Connection.Database + 
                    " COLLATE Persian_100_CI_AI");
            }

            this.Configuration.AutoDetectChangesEnabled = true;
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Absence>().ToTable("Absence").HasKey(x => x.Id);
            modelBuilder.Entity<Agent>().ToTable("Agent").HasKey(x => x.Id);
            modelBuilder.Entity<Mission>().ToTable("Mission").HasKey(x => x.MisId);
            modelBuilder.Entity<OffDay>().ToTable("OffDay").HasKey(x => x.Id);
            modelBuilder.Entity<Office>().ToTable("Office").HasKey(x => x.Id);
            modelBuilder.Entity<OnDuty>().ToTable("OnDuty").HasKey(x => x.Id);
            modelBuilder.Entity<Rank>().ToTable("Rank").HasKey(x => x.Id);
            modelBuilder.Entity<Session>().ToTable("Session").HasKey(x => x.SesId);
            modelBuilder.Entity<Signature>().ToTable("Signature").HasKey(x => x.Id);
            modelBuilder.Entity<Sports>().ToTable("Sports").HasKey(x => x.Id);
            modelBuilder.Entity<UndTreat>().ToTable("UndTreat").HasKey(x => x.Id);
            modelBuilder.Entity<Unit>().ToTable("Unit").HasKey(x => x.Id);
            modelBuilder.Entity<User>().ToTable("User").HasKey(x => x.UsrId);
        }
    }
}
