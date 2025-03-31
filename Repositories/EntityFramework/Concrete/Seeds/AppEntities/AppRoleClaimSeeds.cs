using Core.Entities.Abstract;
using Core.Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppRoleClaimSeeds : IEntityTypeConfiguration<AppRoleClaim>
    {
        public void Configure(EntityTypeBuilder<AppRoleClaim> builder)
        {
            List<AppRoleClaim> AppRoleClaimList = new()
            {
                new AppRoleClaim
                {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimId = 1,
                    RoleId = 1,
                  
                },
                   new AppRoleClaim
                {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimId = 2,
                    RoleId = 1,

                },   new AppRoleClaim
                {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimId = 3,
                    RoleId = 1,

                }
                ,   new AppRoleClaim
                {
                    Id = 4,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimId = 4,
                    RoleId = 1,

                }
                ,   new AppRoleClaim
                {
                    Id = 5,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimId = 5,
                    RoleId = 1,

                }
                ,new AppRoleClaim
                {
                    Id = 6,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimId = 6,
                    RoleId = 1,
                }

            };


            builder.HasData(AppRoleClaimList);
        }
    }
}
