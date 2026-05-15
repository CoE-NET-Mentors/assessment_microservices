namespace Orders.Api.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public string CustomerId { get; set; } = string.Empty;

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public DateTime CreatedAt { get; set; }
    }
}
