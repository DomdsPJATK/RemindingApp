using Microsoft.EntityFrameworkCore;

namespace WebApplication.Model
{
    public class BakeryContext : DbContext
    {
        protected BakeryContext()
        {
        }

        public BakeryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}