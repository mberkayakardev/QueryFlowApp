using Core.Entities.Concrete.AppEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppMVCMenuSeeds : IEntityTypeConfiguration<AppMVCMenus>
    {
        public void Configure(EntityTypeBuilder<AppMVCMenus> builder)
        {
            List<AppMVCMenus> appMVCMenus = new List<AppMVCMenus>{
                new AppMVCMenus
                {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                    RootId = null,
                    MenuOrderNumber = 0,
                    AppApplicationTypeId = 1,
                    AreaName = "",
                    ControllerName = "",
                    ActionName = "",
                    Parameter = "",
                    MenuIcon = "nav-icon fas fa-copy",
                    IsNewTab = false,
                    MenuDescription ="Sınav Base menü",
                    MenuName ="Sınav",
                    AppClaimId = 2

                },
                  new AppMVCMenus
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                    RootId = 1,
                    MenuOrderNumber = 0,
                    AppApplicationTypeId = 1,
                    AreaName = "Admin",
                    ControllerName = "Survey",
                    ActionName = "Index",
                    Parameter = "",
                    MenuIcon = "nav-icon fas fa-copy",
                    IsNewTab = false,
                    MenuDescription ="Sınav Kartlarını Görüntüle ",
                    MenuName ="Sınav Kartları",
                    AppClaimId = 3


                },
                      new AppMVCMenus
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                    RootId = null,
                    MenuOrderNumber = 0,
                    AppApplicationTypeId = 1,
                    AreaName = "",
                    ControllerName = "",
                    ActionName = "",
                    Parameter = "",
                    MenuIcon = "nav-icon fas fa-copy",
                    IsNewTab = false,
                    MenuDescription ="Admin Modül Root menü",
                    MenuName ="Admin Modül",
                    AppClaimId = 4


                },
                      new AppMVCMenus
                {
                    Id = 4,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    CreatedUserId = null,
                    CreatedUserName = "Seed Data",
                    ModifiedUserId = null,
                    RootId = 3,
                    MenuOrderNumber = 0,
                    AppApplicationTypeId = 1,
                    AreaName = "",
                    ControllerName = "",
                    ActionName = "",
                    Parameter = "",
                    MenuIcon = "nav-icon fas fa-copy",
                    IsNewTab = false,
                    MenuDescription ="Kullanıcılar",
                    MenuName ="Kullanıcı",
                    AppClaimId = 5


                }
                  


            };


            builder.HasData(appMVCMenus);



        }
    }
}
