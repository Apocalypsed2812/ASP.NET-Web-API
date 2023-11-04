using TikiAPI.Data;
using TikiAPI.DTO;
using TikiAPI.Models;

namespace TikiAPI.Repositories.OrderRepository
{
    public interface IOrderRepository
    {
        public Task<OrderDTO> GetAllOrdersAsync();
        public Task AddOrderAsync(int accountId, List<ProductModel> products);
    }
}
