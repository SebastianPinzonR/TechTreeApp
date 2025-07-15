namespace TechTreeMVCApplication.Entities
{
    public class Contenido
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string HTMLContent { get; set; } = null!;
        public string VideoLink { get; set; } = null!;
        public int CategoriaItemId { get; set; }
    }
}
