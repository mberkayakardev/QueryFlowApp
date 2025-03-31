using Core.Entities.Concrete.AppEntities;
using Core.Utilities.Results.MVC.BaseResult;
using Dtos.Concrete.AppMVCMenusDto;
using QuizApp.Services.Abstract.Base;

namespace Services.Abstract
{
    public interface IMenuService : IBaseServices
    {
        Task<IApiDataResult<List<ListAppMVCMenusDto>>> GetAppMVCMenusForUser(int UserId);
    }
}
