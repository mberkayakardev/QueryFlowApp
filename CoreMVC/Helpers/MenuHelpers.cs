using Dtos.Concrete.AppMVCMenusDto;

namespace CoreMVC.Helpers
{
    public static class MenuHelpers
    {
        public static List<ListAppMVCMenusDto> BuildMenuHierarchy(List<ListAppMVCMenusDto> items, int? parentId)
        {
            return items
                .Where(i => i.RootId == parentId)
                .Select(i => new ListAppMVCMenusDto
                {
                    Id = i.Id,
                    RootId = i.RootId,
                    MenuName = i.MenuName,
                    MenuDescription = i.MenuDescription,
                    AreaName = i.AreaName,
                    ControllerName = i.ControllerName,
                    ActionName = i.ActionName,
                    Parameter = i.Parameter,
                    MenuIcon = i.MenuIcon,
                    IsNewTab = i.IsNewTab,
                    ChildMenus = BuildMenuHierarchy(items, i.Id)
                })
                .ToList();
        }

        
    }
}
