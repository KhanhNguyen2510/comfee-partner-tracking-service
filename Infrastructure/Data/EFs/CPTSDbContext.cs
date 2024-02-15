using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.EFs
{
    public partial class CPTSDbContext : DbContext
    {
        public CPTSDbContext()
        {
        }

        public CPTSDbContext(DbContextOptions<CPTSDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        { }
    }
}