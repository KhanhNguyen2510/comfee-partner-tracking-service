using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.EFs
{
	public class CPTSDbContext : DbContext
    {
        public CPTSDbContext()
        {
        }

        public CPTSDbContext(DbContextOptions<CPTSDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}

