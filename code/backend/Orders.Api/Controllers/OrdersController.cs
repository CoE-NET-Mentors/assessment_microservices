using Microsoft.AspNetCore.Mvc;
using Orders.Api.Contracts.Requests;
using Orders.Api.Contracts.Responses;
using Orders.Api.Domain;

namespace Orders.Api.Controllers
{
    [Route("api/orders"), ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public Task<OrderResponse> CreateAsync(CreateOrderRequest request)
            => throw new NotImplementedException();

        [HttpGet]
        public Task<IEnumerable<OrderResponse>> GetAllAsync(
            [FromQuery] string? customerId,
            [FromQuery] OrderStatus? status)
            => throw new NotImplementedException();

        [HttpPut("{id:guid}")]
        public Task<OrderResponse?> UpdateStatusAsync(
            Guid id,
            UpdateOrderStatusRequest request)
            => throw new NotImplementedException();

        [HttpGet("summary")]
        public Task<OrdersSummaryResponse> GetSummaryAsync()
            => throw new NotImplementedException();
    }
}
