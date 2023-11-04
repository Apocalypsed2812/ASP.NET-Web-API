using Microsoft.EntityFrameworkCore;

namespace TikiAPI.Repositories
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(int id, T entity);
    }
}
