namespace AuraEcho.Api.Models.V1.Auth;

public class AuthResponse
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public DateTimeOffset ExpiresAt { get; set; }
    public AppUserDto User { get; set; }
}
