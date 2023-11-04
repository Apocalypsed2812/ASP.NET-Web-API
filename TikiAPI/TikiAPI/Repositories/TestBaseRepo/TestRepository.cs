using Microsoft.EntityFrameworkCore;
using TikiAPI.Data;
using TikiAPI.Specifications;

namespace TikiAPI.Repositories.TestBaseRepo
{
    public class TestRepository : BaseRepository<Category>, ITestRepository
    {
        public TestRepository(IUnitOfWork unitOfWork) : base(unitOfWork) {
            
        }
        public Task<Category> GetCategoryByNameAsync(string categoryName)
        {
            throw new NotImplementedException();
        }
    }
}
