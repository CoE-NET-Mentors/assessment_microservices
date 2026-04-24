using Orders.Api.Contracts.InventoryApi;

namespace Orders.Api.Clients
{
    public class InventoryApiClient : IInventoryApiClient
    {        

        public Task<ProductResponse?> GetProductAsync(Guid productId)
            => throw new NotImplementedException();

        public Task<bool> AdjustStockAsync(Guid productId, AdjustStockRequest request)
            => throw new NotImplementedException();
    }
}
