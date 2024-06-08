using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using PlanningPoker.Shared;
using System;

namespace PlanningPoker.Server.Data
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {
        }

        public DbSet<UserStory> UserStories { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserStory>()
                .HasMany(us => us.Works);

            base.OnModelCreating(modelBuilder);
        }

    }
}
