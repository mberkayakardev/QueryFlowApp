using CoreMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NToastNotify;

namespace CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        private readonly IToastNotification _toastNotification;
        public HomeController(IHttpClientFactory httpClient, IOptions<AppConfigReadModel> config, IToastNotification toastNotification)
        {
            _httpClient = httpClient.CreateClient("ApiClient");
            _Config = config.Value;
            _toastNotification = toastNotification;
        }

        /// <summary>
        ///  Kullanıcı Ana Sayfası 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

    }
}
