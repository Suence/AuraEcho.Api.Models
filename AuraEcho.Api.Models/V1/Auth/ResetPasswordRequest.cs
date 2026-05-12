using System.ComponentModel.DataAnnotations;

namespace AuraEcho.Api.Models.V1.Auth;

public class ResetPasswordRequest
{
    [Required]
    public string Email { get; set; }

    [Required]
    public string EmailCode { get; set; }

    [Required]
    public string NewPassword { get; set; }     
}
