using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Usuarios.Context;
using Usuarios.Domain;
using Usuarios.DTO;
using Usuarios.Usuario.Interface;

namespace Usuarios.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuario _usuario;

        public UsuarioController( IUsuario usuario)
        {
            this._usuario = usuario;
        }

        //// GET ////
        #region GET
        [HttpGet]
        public async Task<ActionResult<List<DTOUsuario>>> GetAll()
        {
           var result = await _usuario.GetAll();
           return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetUsuario")]
        public async Task<ActionResult<DTOUsuario>> GetID(int id)
        {
            var result = await _usuario.GetID(id);
            return result;
        }

        #endregion

        //// POST ////
        #region POST
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DTOUsuarioC pDTOU)
        {
            var action = await _usuario.Post(pDTOU);
            var result = action.Value;

            if (result > 0) { return Ok(); }
            //////////////////////////////////////////
            return BadRequest("no fue posible hacer la accion");
        }

        #endregion

        ///// PUT ////
        #region PUT
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put([FromBody] DTOUsuarioP pDTOU ,int id)
        {
            var action = await _usuario.Put(pDTOU,id);
            var result = action.Value;

            if (result > 0) { return Ok(); }
            //////////////////////////////////////////
            return BadRequest("no fue posible hacer la accion");
        }

        #endregion

        //// DELETE ////
        #region DELETE
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var action = await _usuario.Delete(id);
            var result = action.Value;

            if (result > 0) { return Ok(); }
            //////////////////////////////////////////
            return BadRequest("no fue posible hacer la accion");
        }

        #endregion


        ///////////////////////////////////////
    }
}
