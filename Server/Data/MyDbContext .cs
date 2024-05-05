using Microsoft.EntityFrameworkCore;
using Npgsql;
using PlanningPoker.Shared;
using System.Threading.Tasks;
using System;

namespace PlanningPoker.Server.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserStory> UserStories { get; set; }
        public async Task CheckDatabaseConnectionAsync()
        {
            using (var connection = new NpgsqlConnection("Host=aws-0-eu-central-1.pooler.supabase.com;Database=postgres;Username=postgres.rcbzzqgkhbemngykoozi;Password=J5f87lMOoIEdk0IK;Port=6543;"))
            {
                await connection.OpenAsync();
                using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM pg_stat_activity WHERE state = 'active';", connection))
                {
                    var activeConnections = (long)await command.ExecuteScalarAsync();
                    Console.WriteLine($"Number of active connections: {activeConnections}");
                }
            }
        }

    }
}
