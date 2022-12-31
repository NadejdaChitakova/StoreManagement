using DatabaseShemaManager.DataAccess;
using DatabaseShemaManager.Model;
using System.Data.Entity;

namespace AuthorizationAPI.DataAccess
{
    public class DBContext : DatabaseShemaManager.DataAccess.DBContext
    {
        public DbSet<User> Users { get; set; }
    }
}
