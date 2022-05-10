using Microsoft.EntityFrameworkCore;

namespace ConsumoVeiculos.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //configurando a injeção de dependência
        {

        }
    }
}
