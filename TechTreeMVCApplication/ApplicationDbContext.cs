using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechTreeMVCApplication.Entities;

namespace TechTreeMVCApplication
{
    public class UsuarioAplicacion:IdentityUser
    {
        
        [StringLength(250)]
        public string Nombre { get; set; } = null!;

        [StringLength(250)]
        public string Apellido { get; set; } = null!;

        [StringLength(250)]
        public string Direccion1 { get; set; } = null!;

        [StringLength(250)]
        public string Direccion2 { get; set; } = null!;

        [StringLength(50)]
        public string CodigoPostal { get; set; } = null!;
        [ForeignKey("TipodeUsuarioId")]
        public virtual ICollection<TipodeUsuario> TipodeUsuarios { get; set; } = null!;
    }
    public class ApplicationDbContext : IdentityDbContext <UsuarioAplicacion>
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CategoriaItem> CategoriasItem { get; set; }
        public DbSet<Contenido> Contenido { get; set; }
        public DbSet<TipodeMedio> TipodeMedio { get; set; }
        public DbSet<TipodeUsuario> TipodeUsuario { get; set; }
        
    }

}
