namespace AuraEcho.Api.Models.V1.Order;

public class CreateOrderResponse
{
    public Guid OrderId { get; set; }
    public string PayUrl { get; set; }
    public string QRCode { get; set; }
}
