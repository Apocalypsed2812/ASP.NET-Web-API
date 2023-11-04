using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TikiAPI.Data;
using TikiAPI.Models;
using TikiAPI.Repositories.OrderRepository;

namespace TikiAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepo;

        public OrderController(IOrderRepository service)
        {
            _orderRepo = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                return Ok(await _orderRepo.GetAllOrdersAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(int accountId, List<ProductModel> products)
        {
            await _orderRepo.AddOrderAsync(accountId, products);
            return Ok("Add Order Successfully");
        }
        
    }
}
