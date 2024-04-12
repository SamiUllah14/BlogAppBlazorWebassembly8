
using BlogApp.Client.Authentication;

namespace BlogApp.Client.Services.AuthenticationService
{
    public interface IAuthService
    {
        Task<int> Register(UserRegister userRegister);

    }
}
