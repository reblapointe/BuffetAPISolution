using BuffetAPI.Models;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuffetAPI.Configurations
{
    public class TypePlatConfiguration : IEntityTypeConfiguration<TypePlat>
    {
        public void Configure(EntityTypeBuilder<TypePlat> builder)
        {
            builder.HasData(
                new TypePlat { Id = 1, Nom = "Végétarien" },
                new TypePlat { Id = 2, Nom = "Carnivore" },
                new TypePlat { Id = 3, Nom = "Sucrerie" }

            );
        }
    }
}
