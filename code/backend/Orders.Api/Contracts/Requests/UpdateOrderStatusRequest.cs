using Orders.Api.Domain;

namespace Orders.Api.Contracts.Requests
{
    public class UpdateOrderStatusRequest
    {
        public OrderStatus Status { get; set; }
    }
}
