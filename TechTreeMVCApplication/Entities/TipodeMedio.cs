using System.ComponentModel.DataAnnotations.Schema;

namespace TechTreeMVCApplication.Entities
{
    public class TipodeMedio
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string PulgarImagen { get; set; } = null!;
        //Esta es una llave foranea la cual demuestra que esta en contacto con CategoriaItem,
        //Ademas la relacion es de uno a muchos
        [ForeignKey("TipodeMedioId")]
        public virtual ICollection<CategoriaItem> CategoriaItems { get; set; } = null!;
    }
}
