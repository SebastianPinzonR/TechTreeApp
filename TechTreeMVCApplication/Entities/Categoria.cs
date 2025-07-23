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
        //Esta es una llave forane la cual demuestra que esta en contacto con CategoriaItem,
        //Ademas la relacion es de uno a muchos
        //Se crean de manera que bi se reciban validaciones relacionadas con CategoriaItems y TipodeUsuarios
        [ForeignKey("CategoriaId")]
        public virtual ICollection<CategoriaItem> CategoriaItems { get; set; } = new List<CategoriaItem>();
        //Esta es una llave foranea la cual demuestra que esta en contacto con TipodeUsuario,
        //Ademas la relacion es de uno a muchos
        [ForeignKey("CategoriaId")]
        public virtual ICollection<TipodeUsuario> TipodeUsuarios { get; set; } = new List<TipodeUsuario>();
    }
}
