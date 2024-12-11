using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuffetAPI.Data.SeedConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "Administrateur",
                    NormalizedName = "ADMINISTRATEUR"
                },
                new IdentityRole
                {
                    Name = "Cuisinier",
                    NormalizedName = "CUISINIER"
                },
                new IdentityRole
                {
                    Name = "Ogre",
                    NormalizedName = "OGRE"
                }
            );
        }
    }
}
