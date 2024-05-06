using Microsoft.EntityFrameworkCore;
using Npgsql;
using PlanningPoker.Shared;
using System.Threading.Tasks;
using System;

namespace PlanningPoker.Server.Data
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        public DbSet<UserStory> UserStories { get; set; }
    }
}
