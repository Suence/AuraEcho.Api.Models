using AuraEcho.Api.Models.V1.Common;
using AuraEcho.Api.Models.V1.License;

namespace AuraEcho.Api.Models.V1.Sku;

public class SkuInfo
{
    public Guid? Id { get; set; }

    public Guid ResourceId { get; set; }
    public ResourceType ResourceType { get; set; }

    public LicenseType Type { get; set; }
    public decimal SalePrice { get; set; }
    public decimal OriginalPrice { get; set; }
    public bool IsActive { get; set; }
}
