using Inventory.Api.Contracts.Requests;
using Inventory.Api.Contracts.Responses;
using Inventory.Api.Data;

namespace Inventory.Api.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly InventoryDbContext _dbContext;

        public InventoryService(InventoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ProductResponse?> GetByIdAsync(Guid id)
            => throw new NotImplementedException();

        public Task<bool> AdjustStockAsync(Guid id, AdjustStockRequest request)
            => throw new NotImplementedException();
    }
}
