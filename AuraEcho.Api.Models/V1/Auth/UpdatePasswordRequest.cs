namespace AuraEcho.Api.Models.V1.Auth;

public class UpdatePasswordRequest
{
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
}
