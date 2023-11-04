﻿using TikiAPI.Data;
using TikiAPI.DTO;
using TikiAPI.Models;

namespace TikiAPI.Repositories.AccountRepository
{
    public interface IAccountRepository
    {
        public Task<Account> LoginAsync(string username, string password);
        public Task<AccountDTO> RegisterAsync(AccountModel model);
        public Task<AccountModel> GetAccountByUsername(string username);
        public Task AddToCart(int accountId, int productId);
        public Task<UserCartDTO> GetUserCart(int userId);
        public Task<bool> DeleteProductFromCart(int accountId, int productId);
        public Task<int> ChangeQuantity(int productId, string handle);
    }
}