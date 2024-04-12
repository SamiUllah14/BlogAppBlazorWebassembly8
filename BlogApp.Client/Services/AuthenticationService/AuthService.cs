
using BlogApp.Client.Authentication;

using System.Text;
using System.Text.Json;

namespace BlogApp.Client.Services.AuthenticationService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> Register(UserRegister userRegister)
        {
            var userRegisterJson = JsonSerializer.Serialize(userRegister);
            var response = await _httpClient.PostAsync("api/auth/register", new StringContent(userRegisterJson, Encoding.UTF8, "application/json"));

            response.EnsureSuccessStatusCode();

            var userId = await response.Content.ReadFromJsonAsync<int>();
            return userId;
        }
    }
}
