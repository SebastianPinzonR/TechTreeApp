using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechTreeMVCApplication.Entities;

namespace TechTreeMVCApplication
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaItem> CategoriasItem { get; set; }
        public DbSet<Contenido> Contenido { get; set; }
        public DbSet<TipodeMedio> TipodeMedio { get; set; }
        public DbSet<TipodeUsuario> TipodeUsuario { get; set; }
        public DbSet<UsuarioAplicacion> usuariosdelaAplicacion { get; set; }
    }

}
