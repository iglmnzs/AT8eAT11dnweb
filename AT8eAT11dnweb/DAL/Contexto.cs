using AT8eAT11dnweb.Models;
using Microsoft.EntityFrameworkCore;

namespace AT8eAT11dnweb.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
