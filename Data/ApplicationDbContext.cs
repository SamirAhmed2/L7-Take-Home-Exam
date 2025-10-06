using Microsoft.EntityFrameworkCore;
using ActivityTracker.Models;

namespace ActivityTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; } = null!;
    }
}