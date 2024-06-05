using Microsoft.EntityFrameworkCore;
using Npgsql;
using PlanningPoker.Shared;
using System;

namespace PlanningPoker.Server.Data
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        public DbSet<UserStory> UserStories { get; set; }
        public DbSet<Work> Works { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserStory>()
                .HasMany(us => us.Works)
                .WithOne(t => t.UserStory)
                .HasForeignKey(t => t.UserStoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
