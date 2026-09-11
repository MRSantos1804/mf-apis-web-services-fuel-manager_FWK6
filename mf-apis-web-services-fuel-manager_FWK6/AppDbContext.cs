using Microsoft.EntityFrameworkCore;

namespace mf_apis_web_services_fuel_manager_FWK6
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Models.Veiculo> Veiculos { get; set; }
        public DbSet<Models.Consumo> Consumos { get; set; }
    }
}
