using Entities.Concrete.AppEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EntityFramework.Concrete.Seeds.AppEntities
{
    public class AppClaimsSeeds : IEntityTypeConfiguration<AppClaim>
    {
        public void Configure(EntityTypeBuilder<AppClaim> builder)
        {
            var AppClaimList = new List<AppClaim>
            {
                new AppClaim {
                    Id = 1,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.Dashboard",
                    ClaimDescription = "Admin Layout içerisindeki Dashboard ın görülebilmesi için eklenmiş olan bir cliam dir."
                },
                new AppClaim {
                    Id = 2,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.Survey.BaseMenu",
                    ClaimDescription = "Anket / Sınavlar için base modülün claim kaydıdır. "
                },
                  new AppClaim {
                    Id = 3,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.Survey.Index",
                    ClaimDescription = "Anket / Sınavlar için Kullanıcının Kendi kartlarını görüntüleyebileceği bir claimdir.  "
                },
                      new AppClaim {
                    Id = 4,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.AdminModule",
                    ClaimDescription = "Admin yönetimi - Roller - User - claim - menü yönetimi ve daha fazlası için sistem yönetici yetkisi"
                },
                    new AppClaim {
                    Id = 5,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.AdminModule.Kullanicilar",
                    ClaimDescription = "Admin yönetimi Kullanici yönetimi "},
                                        new AppClaim {
                    Id = 6,
                    IsActive = true,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    CreatedUserId = null,
                    CreatedUserName = "SeedData",
                    ModifiedUserId  = null,
                    ModifiedUserName = "SeedData",
                    ClaimName = "Admin.AdminModule.Kullanicilar.Index",
                    ClaimDescription = "Admin yönetimi Kullanici Görüntüleme"}

            };



            builder.HasData(AppClaimList);
        }
    }
}
