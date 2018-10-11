using System.Threading.Tasks;
using EricABP.Configuration.Dto;

namespace EricABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
