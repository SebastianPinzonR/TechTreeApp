using System.ComponentModel.DataAnnotations;

namespace TechTreeMVCApplication.Entities
{
    public class CategoriaItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime DateTimeItemAdded { get; set; }
        public int CategoriaId { get; set; }
        public int TipodeMedioId { get; set; }        
    }
}
