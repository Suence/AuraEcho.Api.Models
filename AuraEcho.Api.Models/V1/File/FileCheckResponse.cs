namespace AuraEcho.Api.Models.V1.File;

public class FileCheckResponse
{
    public bool IsUploaded { get; set; }
    public Guid? FileId { get; set; }
    public string FileUrl { get; set; }
}
