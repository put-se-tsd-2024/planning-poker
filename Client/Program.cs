using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PlanningPoker.Client.Services;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;

namespace PlanningPoker.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<RoomStatusManager>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddAuthorizationCore();

            await builder.Build().RunAsync();
        }
    }
}
