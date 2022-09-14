using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace Usuarios.Domain
{
    public class User
    {
        public int UsuarioID            { get; set; }
        public string Nombre            { get; set; }
        public string ApP               { get; set; }
        public string ApM               { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int RazonSocialID        { get; set; }
    }
}
