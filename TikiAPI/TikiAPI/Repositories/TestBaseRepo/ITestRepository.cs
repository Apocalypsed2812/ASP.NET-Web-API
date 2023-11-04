using TikiAPI.Data;
using TikiAPI.Specifications;

namespace TikiAPI.Repositories.TestBaseRepo
{
    public interface ITestRepository : IBaseRepository<Category>
    {
        public Task<Category> GetCategoryByNameAsync(string categoryName);
    }
}
