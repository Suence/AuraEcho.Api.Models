namespace AuraEcho.Api.Models.V1.Plugin;

public class PluginScreenshotResponseItem
{
    public Guid Id { get; set; }
    public Guid PluginId { get; set; }
    public Guid FileId { get; set; }
    public string FileUrl { get; set; }
    public int Order { get; set; }
}
