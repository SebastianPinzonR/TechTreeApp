using System.ComponentModel.DataAnnotations.Schema;

namespace TechTreeMVCApplication.Entities
{
    public class TipodeMedio
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string PulgarImagen { get; set; } = null!;
        [ForeignKey("CategoriaItemId")]
        public virtual ICollection<CategoriaItem> CategoriaItems { get; set; } = null!;
    }
}
