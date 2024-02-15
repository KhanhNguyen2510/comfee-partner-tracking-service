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
                  .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariables()["ASPNETCORE_ENVIRONMENT"]}.json")
                  .Build();

            DbContextOptionsBuilder<CPTSDbContext> optionsBuilder = new();

            string? connectionString = configurationRoot.GetConnectionString("Comfee_PTSConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new CPTSDbContext(optionsBuilder.Options);
        }
    }
}

