using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tally.Core.Models.Entities;

namespace Tally.Data
{
    public class TallyDbContext : IdentityDbContext<User>
    {
        public TallyDbContext(DbContextOptions<TallyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Container> Containers { get; set; }
        public DbSet<CustomCatagory> CustomCatagories { get; set; }
        public DbSet<CommonCatagory> CommonCatagories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Add custom configuration here if needed
        }
    }
}