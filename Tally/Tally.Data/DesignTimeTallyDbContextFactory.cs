using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Tally.Data
{
    public class DesignTimeTallyDbContextFactory : IDesignTimeDbContextFactory<TallyDbContext>
    {
        public TallyDbContext CreateDbContext(string[] args)
        {
            // Adjust the path as needed for your solution structure
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("C:\\Users\\crris\\source\\repos\\TallyProject\\Tally\\Tally.Api\\appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<TallyDbContext>();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DatabaseConnectionString"));

            return new TallyDbContext(optionsBuilder.Options);
        }
    }
}