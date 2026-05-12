namespace AuraEcho.Api.Models.V1.Auth;

public class AppUserDto
{
    public Guid UserId { get; set; }
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public Guid? AvatarFileId { get; set; }
}
