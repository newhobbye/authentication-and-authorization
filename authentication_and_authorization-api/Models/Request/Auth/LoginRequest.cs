using System.Diagnostics;

namespace authentication_and_authorization_api.Models.Request.Auth
{
    [DebuggerDisplay("Email: {Email}, Password: {Password}")]
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
