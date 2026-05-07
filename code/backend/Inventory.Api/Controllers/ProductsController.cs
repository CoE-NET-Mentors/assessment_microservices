using Microsoft.AspNetCore.Mvc;
using Inventory.Api.Contracts.Requests;
using Inventory.Api.Contracts.Responses;

namespace Inventory.Api.Controllers
{
    [Route("api/products"), ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("{id:guid}")]
        public Task<ProductResponse?> GetByIdAsync(Guid id)
            => throw new NotImplementedException();

        [HttpPatch("{id:guid}/stock")]
        public Task<bool> AdjustStockAsync(Guid id, AdjustStockRequest request)
            => throw new NotImplementedException();
    }
}
