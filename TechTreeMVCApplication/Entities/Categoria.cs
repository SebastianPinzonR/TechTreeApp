namespace TechTreeMVCApplication.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string PulgarImagen { get; set; } = null!;
    }
}
