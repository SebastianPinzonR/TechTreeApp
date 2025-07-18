using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTreeMVCApplication.Entities
{
    public class Contenido
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Titulo { get; set; } = null!;
        public string HTMLContent { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
        //Esta es una relacion uno a uno
        
        public int CategoriaItemId { get; set; } // Clave foránea
        public CategoriaItem CategoriaItem { get; set; } // Navegación
    }
}
