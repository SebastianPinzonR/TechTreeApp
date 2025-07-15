using System.ComponentModel.DataAnnotations;

namespace TechTreeMVCApplication.Entities
{
    public class UsuarioAplicacion
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Nombre { get; set; } = null!;

        [StringLength(250)]
        public string Apellido { get; set; } = null!;

        [StringLength(250)]
        public string Direccion1 { get; set; } = null!;

        [StringLength(250)]
        public string Direccion2 { get; set; } = null!;

        [StringLength(50)]
        public string CodigoPostal { get; set; } = null!;
    }
}
