namespace BlogApp.Server.Services.AuthenticationService
{
    public interface IAuthService
    {
        Task<int> UserRegister(User user, string password);
        Task<bool> UserExists(string email);
    }
}
