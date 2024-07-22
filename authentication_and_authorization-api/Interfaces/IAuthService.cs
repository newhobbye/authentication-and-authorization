using authentication_and_authorization_api.Models.Request.Auth;

namespace authentication_and_authorization_api.Interfaces
{
    public interface IAuthService
    {
        string GenerateTokenAsync(LoginRequest request);
    }
}
