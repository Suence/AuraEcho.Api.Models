namespace AuraEcho.Api.Models.V1.File;

public class StsToken
{
    public required string AccessKeyId { get; set; }
    public required string AccessKeySecret { get; set; }
    public required string SecurityToken { get; set; }
    public required string Expiration { get; set; }
    public required string CallbackUrl { get; set; }
}
