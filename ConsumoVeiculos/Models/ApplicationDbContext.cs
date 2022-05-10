using Microsoft.EntityFrameworkCore;

namespace ConsumoVeiculos.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) //configurando a injeção de dependência
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
