using CoreMVC.Extentions;
using CoreMVC.Models;
using Dtos.Concrete.AppMVCMenusDto;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Net;
using CoreMVC.Helpers;
using Core.Utilities.Helper;
using System.Security.Claims;
using Core.Utilities.Exceptions;
using Microsoft.Extensions.Options;

namespace CoreMVC.Areas.Admin.Components.Navbar
{
    public class NavbarViewComponent : ViewComponent
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        private readonly IToastNotification _toastNotification;
        public NavbarViewComponent(IHttpClientFactory httpClient, IOptions<AppConfigReadModel> config, IToastNotification toastNotification)
        {
            _httpClient = httpClient.CreateClient("ApiClient");
            _Config = config.Value;
            _toastNotification = toastNotification;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var LoginUser = HttpContext.User?.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

            if (LoginUser == null)
                throw new SessionExpiredException("");

            var response = await _httpClient.CostumeGetAsync<List<ListAppMVCMenusDto>>($"{_Config.BaseUrl}/Menus/MVC/{LoginUser}", _toastNotification);
            if (response.Item1.StatusCode == HttpStatusCode.BadRequest)
            {
                _toastNotification.AddErrorToastMessage("Bir Hata oluştu : " + (response.Item2.Messages));
                return View();
            }

            var RecursiveMenus = MenuHelpers.BuildMenuHierarchy(response.Item2.Data, null);
            return View(RecursiveMenus);
        }
    }
}
