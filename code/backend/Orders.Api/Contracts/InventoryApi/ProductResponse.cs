namespace Orders.Api.Contracts.InventoryApi
{
    public class ProductResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Stock { get; set; }
    }
}
