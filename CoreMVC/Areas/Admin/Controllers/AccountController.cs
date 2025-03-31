using Core.Dtos.Concrete;
using Core.Utilities.Results.MVC.BaseResult;
using CoreMVC.Extentions;
using CoreMVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using NToastNotify;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

namespace CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        private readonly IToastNotification _toastNotification;
        public AccountController(IHttpClientFactory httpClient, IOptions<AppConfigReadModel> config, IToastNotification toastNotification)
        {
            _httpClient = httpClient.CreateClient("ApiClient");
            _Config = config.Value;
            _toastNotification = toastNotification;
        }

        #region Login Page 
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var response = await _httpClient.CostumePostAsync<TokenDto>($"{_Config.BaseUrl}/Auth/CreateToken", JsonSerializer.Serialize(loginDto), _toastNotification, this  );

                if ( (response.Item1 as HttpResponseMessage).IsSuccessStatusCode )
                {
                    var tokenResult = response.Item2;

                    var authenticationTokenList = new List<AuthenticationToken>() {
                        new AuthenticationToken {
                        Name=OpenIdConnectParameterNames.AccessToken , Value =  tokenResult.Data.AccessToken
                        }
                    };

                    var handler = new JwtSecurityTokenHandler();
                    var jwtToken = handler.ReadJwtToken(tokenResult.Data.AccessToken);

                    var identity = new ClaimsIdentity("MyCookieAuth");
                    identity.AddClaims(jwtToken.Claims);

                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("MyCookieAuth", principal, new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(30)
                    });

                    HttpContext.Session.SetString("access_token", tokenResult.Data.AccessToken);
                    HttpContext.Session.SetString("refresh_token", tokenResult.Data.RefreshToken);

                    _toastNotification.AddSuccessToastMessage("Giriş işlemi başarılı ");

                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }

                return View(loginDto);

            }

            return View(loginDto);




        }
        #endregion

    }
}
