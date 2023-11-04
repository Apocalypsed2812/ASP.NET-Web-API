using TikiAPI.Data;

namespace TikiAPI.Repositories
{
    public class DbFactory : Disposable, IDbFactory
    {
        Context context;
        //private readonly DbContextOptions<HobbyContext> options;

        //public DbFactory(DbContextOptions<HobbyContext> options)
        //{
            //this.options = options;
        //}

        public Context Init()
        {
            //return context ?? (context = new HobbyContext(options));
            return null;
        }
        protected override void DisposeCore()
        {
            if(context != null)
            {
                context.Dispose();
            }
        }
    }
}
