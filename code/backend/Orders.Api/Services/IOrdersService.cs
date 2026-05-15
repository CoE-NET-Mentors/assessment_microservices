using Orders.Api.Contracts.Requests;
using Orders.Api.Contracts.Responses;
using Orders.Api.Domain;

namespace Orders.Api.Services
{
    public interface IOrdersService
    {
        Task<OrderResponse> CreateAsync(CreateOrderRequest request);

        Task<IEnumerable<OrderResponse>> GetAllAsync(string? customerId, OrderStatus? status);

        Task<OrderResponse?> UpdateStatusAsync(Guid id, UpdateOrderStatusRequest request);

        Task<OrdersSummaryResponse> GetSummaryAsync();
    }
}
