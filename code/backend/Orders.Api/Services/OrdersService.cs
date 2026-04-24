using Orders.Api.Contracts.Requests;
using Orders.Api.Contracts.Responses;
using Orders.Api.Data;
using Orders.Api.Domain;

namespace Orders.Api.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly OrdersDbContext _dbContext;

        public OrdersService(OrdersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<OrderResponse> CreateAsync(CreateOrderRequest request)
            => throw new NotImplementedException();

        public Task<IEnumerable<OrderResponse>> GetAllAsync(string? customerId, OrderStatus? status)
            => throw new NotImplementedException();

        public Task<OrderResponse?> UpdateStatusAsync(Guid id, UpdateOrderStatusRequest request)
            => throw new NotImplementedException();

        public Task<OrdersSummaryResponse> GetSummaryAsync()
            => throw new NotImplementedException();

        private static bool IsValidStatusTransition(OrderStatus currentStatus, OrderStatus newStatus)
        {
            return currentStatus == OrderStatus.Pending
                && (newStatus == OrderStatus.Confirmed || newStatus == OrderStatus.Cancelled);
        }
    }
}
