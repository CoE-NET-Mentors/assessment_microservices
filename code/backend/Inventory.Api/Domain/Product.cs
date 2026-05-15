namespace Inventory.Api.Domain
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Stock { get; set; }
    }
}
