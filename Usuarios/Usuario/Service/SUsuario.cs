using Microsoft.AspNetCore.Mvc;
using Usuarios.Domain;
using Usuarios.Usuario.Interface;

namespace Usuarios.Usuario.Service
{
    public class SUsuario : IUsuario
    {
        #region GET
        public Task<ActionResult<List<OUsuario>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<OUsuario>> GetID()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region POST
        public Task<ActionResult> Post()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region PUT
        public Task<ActionResult> Put()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region DELETE  
        public Task<ActionResult> Delete()
        {
            throw new NotImplementedException();
        }

        #endregion

//////////////////////////    
    }
}
