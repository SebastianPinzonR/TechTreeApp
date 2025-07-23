using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [NotMapped]
        public virtual ICollection<SelectListItem> TiposdeMedio { get; set; }
    }
}
