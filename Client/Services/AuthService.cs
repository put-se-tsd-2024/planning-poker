using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace PlanningPoker.Client.Services
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ISessionStorageService _sessionStorage;
        private readonly AuthenticationStateProvider _authStateProvider;

        public event Action OnChange;

        public AuthService(HttpClient httpClient, ISessionStorageService sessionStorage, AuthenticationStateProvider authStateProvider)
        {
            _httpClient = httpClient;
            _sessionStorage = sessionStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task Login(string token)
        {
            await _sessionStorage.SetItemAsync("authToken", token);
            ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(token);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            NotifyStateChanged();
        }

        public async Task Logout()
        {
            await _sessionStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _httpClient.DefaultRequestHeaders.Authorization = null;
            NotifyStateChanged();
        }

        public async Task<string> GetToken()
        {
            return await _sessionStorage.GetItemAsync<string>("authToken");
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
