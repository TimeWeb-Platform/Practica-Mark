using Microsoft.AspNetCore.Mvc;
using Usuarios.Domain;

namespace Usuarios.Usuario.Interface
{
    public interface IUsuario
    {
        Task<ActionResult<OUsuario>> GetAll();
        Task<ActionResult<OUsuario>> GetID();
        Task<ActionResult<OUsuario>> Post();
        Task<ActionResult<OUsuario>> Put();
        Task<ActionResult<OUsuario>> Delete();
        
        
    }
}
