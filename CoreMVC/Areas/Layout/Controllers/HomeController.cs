using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NToastNotify;

namespace CoreMVC.Areas.Layout.Controllers
{
    [Area("Layout")]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly AppConfigReadModel _Config;
        private readonly IToastNotification _toastNotification;
        public HomeController(IHttpClientFactory httpClient, IOptions<AppConfigReadModel> config, IToastNotification toastNotification)
        {

            _httpClient = httpClient.CreateClient();
            _Config = config.Value;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
