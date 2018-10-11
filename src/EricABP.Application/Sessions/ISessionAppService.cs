using System.Threading.Tasks;
using Abp.Application.Services;
using EricABP.Sessions.Dto;

namespace EricABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
