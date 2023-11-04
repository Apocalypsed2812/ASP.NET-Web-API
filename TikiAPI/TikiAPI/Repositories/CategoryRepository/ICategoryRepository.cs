using TikiAPI.Data;
using TikiAPI.Models;
using TikiAPI.Specifications;

namespace TikiAPI.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        public Task<List<CategoryModel>> GetAllCategoryAsync();
        public Task<CategoryModel> GetCategoryAsync(int id);
        public Task<int> AddCategoryAsync(CategoryModel model);
        public Task UpdateCategoryAsync(int id, CategoryModel model);
        public Task DeleteCategoryAsync(int id);
        public Task<Category?> GetCategoryByName(Specification<Category> specification);
    }
}
