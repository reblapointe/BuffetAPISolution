﻿using BuffetAPI.Data;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuffetAPI.Data.SeedConfigurations
{
    public class PlatConfiguration : IEntityTypeConfiguration<Plat>
    {
        public void Configure(EntityTypeBuilder<Plat> builder)
        {
            builder.HasData(
                new Plat
                {
                    Id = 1,
                    Nom = "Biscuit Double gingembre",
                    Prix = 2.25,
                    Mange = false,
                    TypePlatId = 3,
                    OgreId = null,
                    CuisinierId = "cuisinier"
                },
                new Plat
                {
                    Id = 2,
                    Nom = "Biscuit Brisures de chocolat",
                    Prix = 2.25,
                    Mange = false,
                    TypePlatId = 3,
                    OgreId = null,
                    CuisinierId = "cuisinier"
                },
                new Plat
                {
                    Id = 3,
                    Nom = "Biscuit Amaretti",
                    Prix = 2.25,
                    Mange = false,
                    TypePlatId = 3,
                    OgreId = null,
                    CuisinierId = "cuisinier"
                },
                new Plat
                {
                    Id = 4,
                    Nom = "Biscuit S'mores au beurre noisette",
                    Prix = 2.25,
                    Mange = false,
                    TypePlatId = 3,
                    OgreId = null,
                    CuisinierId = "cuisinier"
                },
                new Plat
                {
                    Id = 5,
                    Nom = "Biscuit Canneberges",
                    Prix = 2.25,
                    Mange = false,
                    TypePlatId = 3,
                    OgreId = null,
                    CuisinierId = "cuisinier"
                });
        }
    }
}
