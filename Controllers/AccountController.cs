using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using Okta.Sdk;

namespace OktaAspNetCoreMvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly IOktaClient _oktaClient;

        public AccountController(IOktaClient oktaClient = null)
        {
            _oktaClient = oktaClient;
        }

        public IActionResult Login()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return Challenge(OpenIdConnectDefaults.AuthenticationScheme);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
