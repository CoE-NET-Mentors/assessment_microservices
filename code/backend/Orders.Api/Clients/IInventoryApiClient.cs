using Orders.Api.Contracts.InventoryApi;

namespace Orders.Api.Clients
{
    public interface IInventoryApiClient
    {
        Task<ProductResponse?> GetProductAsync(Guid productId);

        Task<bool> AdjustStockAsync(Guid productId, AdjustStockRequest request);
    }
}
