using Microsoft.EntityFrameworkCore;

namespace PIM_4_Semestre.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base (options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
