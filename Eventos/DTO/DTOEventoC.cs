using System.ComponentModel.DataAnnotations;

namespace Eventos.DTO
{
    public class DTOEventoC
    {
        [Required]
        public int UsuarioID { get; set; }
        [Required]
        public DateTime FechaAlta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        [Required] 
        public string Origen { get; set; }
    }
}
