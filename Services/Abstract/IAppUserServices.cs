using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.AppUserDtos;
using QuizApp.Services.Abstract.Base;

namespace QuizApp.Services.Abstract
{
    public interface IAppUserServices : IBaseServices
    {
        Task<IApiDataResult<List<ListAppUserDtos>>> GetAllUserForAdminPanel();

    }
}
