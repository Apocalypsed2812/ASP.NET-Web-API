using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace TikiAPI.Repositories
{
    public interface IUnitOfWork
    {
        IMapper GetMapper();
        DbSet<T> GetDbSet<T>() where T : class;
        Task Commit();
    }
}
