using Inventory.Api.Contracts.Requests;
using Inventory.Api.Contracts.Responses;

namespace Inventory.Api.Services
{
    public interface IInventoryService
    {
        Task<ProductResponse?> GetByIdAsync(Guid id);

        Task<bool> AdjustStockAsync(Guid id, AdjustStockRequest request);
    }
}
