﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TikiAPI.Data;
using TikiAPI.DTO;
using TikiAPI.Models;

namespace TikiAPI.Repositories.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;

        public OrderRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddOrderAsync(int accountId, List<ProductModel> products)
        {
            var order = new Order
            {
                AccountId = accountId,
                OrderProducts = products.Select(p => new OrderProduct { ProductId = p.Id }).ToList(),
                CustomerName = "Anh Tien",
                PhoneNumber = "123456789",
                Address = "Quan 7, TP.HCM",
            };

            _context.Orders!.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<OrderDTO> GetAllOrdersAsync()
        {
            var orders = await _context.Orders!.Include(o => o.OrderProducts)
                                .ThenInclude(op => op.Product)
                                .ToListAsync();

            var orderDTO = _mapper.Map<OrderDTO>(orders);

            return orderDTO;
        }
    }
}
