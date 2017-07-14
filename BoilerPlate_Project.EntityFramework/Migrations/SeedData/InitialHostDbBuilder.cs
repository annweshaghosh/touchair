using BoilerPlate_Project.EntityFramework;
using EntityFramework.DynamicFilters;

namespace BoilerPlate_Project.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly BoilerPlate_ProjectDbContext _context;

        public InitialHostDbBuilder(BoilerPlate_ProjectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
