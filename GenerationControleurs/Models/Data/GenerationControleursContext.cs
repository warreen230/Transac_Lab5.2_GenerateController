using LinqEtSeedEF.Models;
using Microsoft.EntityFrameworkCore;

public class GenerationControleursContext(DbContextOptions<GenerationControleursContext> options) : DbContext(options)
{
    public DbSet<LinqEtSeedEF.Models.Restaurant> Restaurant { get; set; } = default!;

    public DbSet<Restaurant> restaurants { get; set; }
    public DbSet<Client> clients { get; set; }
    public DbSet<Commande> commandes { get; set; }
    public DbSet<Plat> Plats { get; set; }
    public DbSet<CommandePlat> commandePlats { get; set; }
}
