using System.ComponentModel.DataAnnotations;

namespace AuraEcho.Api.Models.V1.Auth;

public class VerifyCodeRequest
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string Code { get; set; }
}
