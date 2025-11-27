using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Tally.Data
{
    public class DesignTimeTallyDbContextFactory : IDesignTimeDbContextFactory<TallyDbContext>
    {
        public TallyDbContext CreateDbContext(string[] args)
        {
            var basePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Tally.Api"));
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<TallyDbContext>();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DatabaseConnectionString"));

            return new TallyDbContext(optionsBuilder.Options);
        }
    }
}