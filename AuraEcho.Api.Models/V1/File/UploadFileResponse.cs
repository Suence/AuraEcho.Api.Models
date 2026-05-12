using System.Text.Json.Serialization;

namespace AuraEcho.Api.Models.V1.File;

public class UploadFileResponse
{
    [JsonPropertyName("fileId")]
    public Guid FileId { get; set; }

    [JsonPropertyName("fileurl")]
    public string FileUrl { get; set; }
}
