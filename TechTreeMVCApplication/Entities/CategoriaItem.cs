namespace TechTreeMVCApplication.Entities
{
    public class CategoriaItem
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime DateTimeItemAdded { get; set; } 
        public int CategoriaId { get; set; }
        public int TipodeMedioId { get; set; }
    }
}
