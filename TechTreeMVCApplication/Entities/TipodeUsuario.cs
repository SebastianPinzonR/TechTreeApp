namespace TechTreeMVCApplication.Entities
{
    public class TipodeUsuario
    {
        public int Id { get; set; }
        //Esta es una relacion de muchos a uno
        public string UsuarioAplicacionId { get; set; } = null!;
        //Esta es una relacion de muchos a uno
        public int CategoriaId { get; set; }
    }
}
