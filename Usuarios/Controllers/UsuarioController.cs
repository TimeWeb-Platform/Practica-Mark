using Microsoft.AspNetCore.Mvc;

namespace Usuarios.Controllers
{
    [ApiController]
    [Route("api/actor")]
    public class UsuarioController : ControllerBase
    {
        //// GET ////
        #region GET
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return NoContent();
        }

        [HttpGet("{id:int}", Name = "GetActor")]
        public async Task<ActionResult> Get(int id)
        {
            return NoContent();
        }

        #endregion

        //// POST ////
        #region POST
        [HttpPost]
        public async Task<ActionResult> Post()
        {
            return NoContent();
        }

        #endregion

        ///// PUT ////
        #region PUT
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put( int id)
        {
            return NoContent();
        }

        #endregion

        //// DELETE ////
        #region DELETE
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return NoContent();
        }

        #endregion


        ///////////////////////////////////////
    }
}
