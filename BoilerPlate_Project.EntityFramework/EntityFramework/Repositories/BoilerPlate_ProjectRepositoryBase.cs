using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BoilerPlate_Project.EntityFramework.Repositories
{
    public abstract class BoilerPlate_ProjectRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BoilerPlate_ProjectDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BoilerPlate_ProjectRepositoryBase(IDbContextProvider<BoilerPlate_ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BoilerPlate_ProjectRepositoryBase<TEntity> : BoilerPlate_ProjectRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BoilerPlate_ProjectRepositoryBase(IDbContextProvider<BoilerPlate_ProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
