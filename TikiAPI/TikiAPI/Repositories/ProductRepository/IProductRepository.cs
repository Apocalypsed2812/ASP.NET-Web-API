using TikiAPI.Data;
using TikiAPI.Models;
using TikiAPI.Specifications;

namespace TikiAPI.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        public Task<List<ProductModel>> GetAllProductsAsync();
        public Task<ProductModel> GetProductAsync(int id);
        public Task<int> AddProductAsync(ProductModel model);
        public Task UpdateProductAsync(int id, ProductModel model);
        public Task DeleteProductAsync(int id);
        public Task<List<Product>> GetProđuctGreaterThanPrice(Specification<Product> specification);
    }
}
