using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BoilerPlate_Project.MultiTenancy.Dto;

namespace BoilerPlate_Project.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
