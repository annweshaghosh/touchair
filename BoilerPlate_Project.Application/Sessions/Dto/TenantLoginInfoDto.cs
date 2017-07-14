using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BoilerPlate_Project.MultiTenancy;

namespace BoilerPlate_Project.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}