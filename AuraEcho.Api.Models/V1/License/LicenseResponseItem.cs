namespace AuraEcho.Api.Models.V1.License;

public class LicenseResponseItem
{
    public bool IsValid { get; set; }
    public LicenseType LicenseType { get; set; }
    public DateTime? ExpiredAt { get; set; }
}
