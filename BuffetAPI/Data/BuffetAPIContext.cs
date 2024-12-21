using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuffetAPI.Data.SeedConfigurations;

namespace BuffetAPI.Data
{
    public class BuffetAPIContext(DbContextOptions<BuffetAPIContext> options) : DbContext(options)
    {
        public DbSet<Plat> Plats { get; set; } = default!;
        public DbSet<TypePlat> TypePlats { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TypePlatConfiguration());
            modelBuilder.ApplyConfiguration(new PlatConfiguration());
        }
    }
}
