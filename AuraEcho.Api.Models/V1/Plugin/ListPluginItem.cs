namespace AuraEcho.Api.Models.V1.Plugin;

public class ListPluginItem
{
    public Guid Id { get; set; }
    public PluginType Type { get; set; }
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public Guid IconFileId { get; set; }
    public string IconFileUrl { get; set; }
    public Guid BannerFileId { get; set; }
    public string BannerFileUrl { get; set; }
    public bool IsEnabled { get; set; }
    public DateTime CreateTime { get; set; }
    public bool IsAcquired { get; set; }
    public int UserCount { get; set; }
}
