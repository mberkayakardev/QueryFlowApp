using Core.Extentions.Concrete.Controller.Api;
using Dtos.Concrete.AppUserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuizApp.Services.Abstract;

namespace WebApi.Controllers
{
    [Authorize]
    public class AdminModulesController : CostumeApiController
    {
        private readonly IAppUserServices _appUserServices;
        public AdminModulesController(IAppUserServices appUserServices)
        {
            _appUserServices = appUserServices;
        }

        [Authorize(Roles = "Admin.AdminModule.Kullanicilar.Index")]
        [HttpGet("Kullanicilar")]

        public async Task<IActionResult> GetAllUserForAdmin()
        {
            return ActionResultInstance(await _appUserServices.GetAllUserForAdminPanel());
        }


    }
}
