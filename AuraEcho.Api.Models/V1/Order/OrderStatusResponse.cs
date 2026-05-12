using AuraEcho.Api.Models.V1.Common;

namespace AuraEcho.Api.Models.V1.Order;

public class OrderStatusResponse
{
    public Guid OrderId { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
