using Microsoft.EntityFrameworkCore;
using AfectacionMedioAmbiental.Models;

namespace AfectacionMedioAmbiental.Data
{
    public class PrincipalContext : DbContext
    {
        public PrincipalContext (DbContextOptions<PrincipalContext> options)
            : base(options)
        {
        }

        public DbSet<Celular> Celulares { get; set; }

        public DbSet<Persona> Personas { get; set; }
    }
}
