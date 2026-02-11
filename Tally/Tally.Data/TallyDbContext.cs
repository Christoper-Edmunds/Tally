using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tally.Data.Entities;

namespace Tally.Data
{
    public class TallyDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

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

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Add custom configuration here if needed

            //Item relationships
            builder.Entity<Item>()
                .HasOne(i => i.Container)
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.ContainerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Item>()
                .HasOne(i => i.CommonCatagory)
                .WithMany(c => c.CommonCatagoryItems)
                .HasForeignKey(i => i.CommonCatagoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Item>()
                .HasOne(i => i.CustomCatagory)
                .WithMany(c => c.CustomCatagoryItems)
                .HasForeignKey(i => i.CustomCatagoryId)
                .OnDelete(DeleteBehavior.Restrict);

            //Container relationships
            builder.Entity<Container>()
                .HasOne(c => c.Room)
                .WithMany(l => l.Containers)
                .HasForeignKey(c => c.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Container>()
                .HasMany(c => c.Items)
                .WithOne(i => i.Container)
                .HasForeignKey(i => i.ContainerId)
                .OnDelete(DeleteBehavior.Restrict);

            //Room relationships
            builder.Entity<Room>()
                .HasOne(r => r.Location)
                .WithMany(l => l.Rooms)
                .HasForeignKey(r => r.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Room>()
                .HasMany(r => r.Containers)
                .WithOne(c => c.Room)
                .HasForeignKey(c => c.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            //Location relationships
            builder.Entity<Location>()
                .HasMany(l => l.Rooms)
                .WithOne(r => r.Location)
                .HasForeignKey(r => r.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // User Relationships
            builder.Entity<User>()
                .HasMany(u => u.Locations)
                .WithMany(i => i.Users)
                .UsingEntity(j => j.ToTable("UserLocations"));

            // FoodDatabase relationships

            builder.Entity<FoodDatabaseFastSearch>()
                .HasOne(f => f.SlowSearchData)
                .WithOne(s => s.FastSearchData)
                .HasForeignKey<FoodDatabaseSlowSearch>(s => s.Code);

            builder.Entity<Item>()
                .HasOne(i => i.FoodDatabaseEntry)
                .WithMany()  // No navigation back to Items from FoodDatabase
                .HasForeignKey(i => i.FoodDatabaseCode)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);  // Optional relationship

        }
    }
}