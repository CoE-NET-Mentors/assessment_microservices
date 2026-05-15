namespace Orders.Api.Contracts.Requests
{
    public class CreateOrderRequest
    {
        public string CustomerId { get; set; } = string.Empty;

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
