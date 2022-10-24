using _24AMProyectoBD.Models;
using Microsoft.EntityFrameworkCore;

namespace _24AMProyectoBD.Context
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
