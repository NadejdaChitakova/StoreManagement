using DatabaseShemaManager.Model;
using System.Data.Entity;


namespace DatabaseShemaManager.DataAccess
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
