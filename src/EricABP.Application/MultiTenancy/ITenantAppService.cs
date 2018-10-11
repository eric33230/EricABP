using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EricABP.MultiTenancy.Dto;

namespace EricABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
