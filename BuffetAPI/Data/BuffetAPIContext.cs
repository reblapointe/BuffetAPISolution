using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BuffetAPI.Data.SeedConfigurations;

namespace BuffetAPI.Data
{
    public class BuffetAPIContext(DbContextOptions<BuffetAPIContext> options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Plat> Plat { get; set; } = default!;
    public DbSet<TypePlat> TypePlat { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new TypePlatConfiguration());
        modelBuilder.ApplyConfiguration(new PlatConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());
    }
}
}
