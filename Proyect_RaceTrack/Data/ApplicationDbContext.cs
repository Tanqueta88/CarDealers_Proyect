using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using herramientas_parcial1_OliveraJorgeDaniel.Models;

namespace Proyect_RaceTrack.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<herramientas_parcial1_OliveraJorgeDaniel.Models.Vehiculo> Vehiculo { get; set; } = default!;
    public DbSet<herramientas_parcial1_OliveraJorgeDaniel.Models.Piloto> Piloto { get; set; } = default!;
}
