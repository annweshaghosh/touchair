using System.Data.Common;
using Abp.Zero.EntityFramework;
using BoilerPlate_Project.Authorization.Roles;
using BoilerPlate_Project.MultiTenancy;
using BoilerPlate_Project.Users;

namespace BoilerPlate_Project.EntityFramework
{
    public class BoilerPlate_ProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public BoilerPlate_ProjectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BoilerPlate_ProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BoilerPlate_ProjectDbContext since ABP automatically handles it.
         */
        public BoilerPlate_ProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BoilerPlate_ProjectDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
