using TikiAPI.Data;

namespace TikiAPI.Repositories
{
    public interface IDbFactory : IDisposable
    {
        Context Init();
    }
}
