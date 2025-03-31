using CoreMVC.Extentions;
using CoreMVC.Models;
using Dtos.Concrete.AppMVCMenusDto;
using Dtos.Concrete.AppUserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NToastNotify;
using System.Net;
using System.Security.Claims;

namespace CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class AdminModuleController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        private readonly IToastNotification _toastNotification;
        public AdminModuleController(IHttpClientFactory httpClient, IOptions<AppConfigReadModel> config, IToastNotification toastNotification)
        {
            _httpClient = httpClient.CreateClient("ApiClient");
            _Config = config.Value;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles ="Admin.AdminModule.Kullanicilar.Index")]
        public async Task<IActionResult> KullanicilarIndex()
        {
            var response = await _httpClient.CostumeGetAsync<List<ListAppUserDtos>>($"{_Config.BaseUrl}/AdminModules/Kullanicilar", _toastNotification);
            if (response.Item1.StatusCode == HttpStatusCode.BadRequest)
            {
                _toastNotification.AddErrorToastMessage("Bir Hata oluştu : " + (response.Item2.Messages));
                return View();
            }


            return View(response.Item2.Data);
        }
    }
}
