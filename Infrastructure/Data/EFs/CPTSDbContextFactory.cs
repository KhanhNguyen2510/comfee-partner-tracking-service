using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.EFs
{
	public class CPTSDbContextFactory : IDesignTimeDbContextFactory<CPTSDbContext>
    {
        public CPTSDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile($"appsettings.json")
                  .Build();

            DbContextOptionsBuilder<CPTSDbContext> optionsBuilder = new();

            string? connectionString = configurationRoot.GetConnectionString("ComfeePTSConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new CPTSDbContext(optionsBuilder.Options);
        }
    }
}