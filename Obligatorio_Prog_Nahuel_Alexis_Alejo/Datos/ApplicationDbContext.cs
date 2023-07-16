using Microsoft.EntityFrameworkCore;
using Obligatorio_Prog_Nahuel_Alexis_Alejo.Models;

namespace Obligatorio_Prog_Nahuel_Alexis_Alejo.Datos

{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Aca van los modelos

        public DbSet<Personas> Personas { get; set; }

    }
}