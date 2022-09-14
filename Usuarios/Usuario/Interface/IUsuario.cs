using Microsoft.AspNetCore.Mvc;
using Usuarios.DTO;

namespace Usuarios.Usuario.Interface
{
    public interface IUsuario
    {
        Task<ActionResult<List<DTOUsuario>>> GetAll();
        Task<ActionResult<DTOUsuario>> GetID(int pID);
        Task<ActionResult<int>> Post(DTOUsuarioC pDTOU);
        Task<ActionResult<int>> Put(DTOUsuarioP pDTOU, int pID);
        Task<ActionResult<int>> Delete(int pID);
        
        
    }
}
