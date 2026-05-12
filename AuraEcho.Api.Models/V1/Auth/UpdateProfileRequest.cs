namespace AuraEcho.Api.Models.V1.Auth;

public class UpdateProfileRequest
{
    public string? UserName { get; set; }
    public Guid? AvatarFileId { get; set; }
}
