using Microsoft.AspNetCore.Antiforgery;
using EricABP.Controllers;

namespace EricABP.Web.Host.Controllers
{
    public class AntiForgeryController : EricABPControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
