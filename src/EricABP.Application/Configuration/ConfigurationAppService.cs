using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using EricABP.Configuration.Dto;

namespace EricABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EricABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
