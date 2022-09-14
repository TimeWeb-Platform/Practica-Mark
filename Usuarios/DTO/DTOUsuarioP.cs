using System.ComponentModel.DataAnnotations;

namespace Usuarios.DTO
{
    public class DTOUsuarioP
    {

        [StringLength(40)]
        public string Nombre { get; set; }
        public string ApP { get; set; }
        public string ApM { get; set; }
        public DateTime FechaNacimiento { get; set; }

        [Range(1, 3)]
        public int RazonSocialID { get; set; }
    }
}
