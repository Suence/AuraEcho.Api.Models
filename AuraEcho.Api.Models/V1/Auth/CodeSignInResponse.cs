namespace AuraEcho.Api.Models.V1.Auth;

public class CodeSignInResponse
{
    public bool IsNewUser { get; set; }
    public AuthResponse Data { get; set; }
}
