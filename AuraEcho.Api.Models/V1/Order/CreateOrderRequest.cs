namespace AuraEcho.Api.Models.V1.Order;

public class CreateOrderRequest
{
    public Guid SkuId { get; set; }
    public PaymentChannel Channel { get; set; }
}
