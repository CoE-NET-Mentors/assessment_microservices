using Orders.Api.Domain;

namespace Orders.Api.Contracts.Responses
{
    public class OrderResponse
    {
        public Guid Id { get; set; }

        public string CustomerId { get; set; } = string.Empty;

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
