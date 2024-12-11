using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuffetAPI.Data.SeedConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BuffetAPI.Data
{
    public class BuffetAPIContext(DbContextOptions<BuffetAPIContext> options) : DbContext(options)
    {
        public DbSet<Plat> Plat { get; set; } = default!;
        public DbSet<TypePlat> TypePlat { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TypePlatConfiguration());
            modelBuilder.ApplyConfiguration(new PlatConfiguration());
        }
    }
}
