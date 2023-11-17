using HistoryProjectAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace HistoryProjectAPI.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<History> Histories { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
