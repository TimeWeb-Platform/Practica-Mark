using System.ComponentModel.DataAnnotations;

namespace Eventos.DTO
{
    public class DTOEventoS
    {
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Origen { get; set; }
    }
}
