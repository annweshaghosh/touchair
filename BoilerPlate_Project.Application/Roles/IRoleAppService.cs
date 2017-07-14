using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlate_Project.Roles.Dto;

namespace BoilerPlate_Project.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
