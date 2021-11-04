using cliente_service.Domain;
using Microsoft.EntityFrameworkCore;

namespace cliente_service.Repository
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}