using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PlanningPoker.Shared;

namespace PlanningPoker.Client
{
    public class AuthStateProvider : AuthenticationStateProvider
    {
        private readonly ISessionStorageService _sessionStorage;
        private readonly HttpClient _httpClient;

        public AuthStateProvider(ISessionStorageService sessionStorage, HttpClient httpClient)
        {
            _sessionStorage = sessionStorage;
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _sessionStorage.GetItemAsync<string>("authToken");
            var identity = string.IsNullOrEmpty(token) ? new ClaimsIdentity() : new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType");

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void NotifyUserAuthentication(string token)
        {
            var identity = new ClaimsIdentity(JwtParser.ParseClaimsFromJwt(token), "jwtAuthType");
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void NotifyUserLogout()
        {
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
