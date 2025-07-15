using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTreeMVCApplication.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Titulo { get; set; } = null!;        
        public string Descripcion { get; set; } = null!;
        [Required]
        public string PulgarImagen { get; set; } = null!;
        [ForeignKey("CategoriaItemId")]
        public virtual ICollection<CategoriaItem> CategoriaItems { get; set; } = null!;
        [ForeignKey("TipoUsuarioId")]
        public virtual ICollection<TipodeUsuario> TipodeUsuarios { get; set; } = null!;
    }
}
