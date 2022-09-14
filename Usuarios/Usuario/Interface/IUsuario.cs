using Microsoft.AspNetCore.Mvc;
using Usuarios.Domain;

namespace Usuarios.Usuario.Interface
{
    public interface IUsuario
    {
        Task<ActionResult<List<OUsuario>>> GetAll();
        Task<ActionResult<OUsuario>> GetID();
        Task<ActionResult> Post();
        Task<ActionResult> Put();
        Task<ActionResult> Delete();
        
        
    }
}
