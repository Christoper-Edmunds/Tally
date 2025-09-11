using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tally.Data.Entities
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

            builder.Entity<Container>()
                .HasOne(c => c.Location)
                .WithMany(l => l.Containers)
                .HasForeignKey(c => c.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Item>()
                .HasOne(i => i.Container)
                .WithOne(c => c.Item)
                .HasForeignKey<Item>(i => i.ContainerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Item>()
                .HasOne(i => i.CommonCatagory)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CommonCatagoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
