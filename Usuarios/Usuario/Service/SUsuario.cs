using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Usuarios.Domain;
using Usuarios.DTO;
using Usuarios.Usuario.Interface;
using Usuarios.Usuario.Repositorie;

namespace Usuarios.Usuario.Service
{
    public class SUsuario : IUsuario
    {
        private readonly RUsuario _rusuario;
        private readonly IMapper  _mapper;

        public SUsuario( RUsuario rusuario, IMapper mapper)
        {
            this._rusuario = rusuario;
            this._mapper   = mapper;
        }

        #region GET
        public async Task<ActionResult<List<DTOUsuario>>> GetAll()
        {
            var users  = await _rusuario.GetAll();
            var result = _mapper.Map<List<DTOUsuario>>(users);
            return result;
        }

        public async Task<ActionResult<DTOUsuario>> GetID(int pID)
        {
            var users = await _rusuario.GetID(pID);
            var result = _mapper.Map<DTOUsuario>(users);
            return result;
        }
        
        #endregion

        #region POST
        public async Task<ActionResult<int>> Post(DTOUsuarioC pDTOU)
        {
            var users  = _mapper.Map<OUsuario>(pDTOU); 
            var action = _rusuario.Post(users);
            var result = await action;

            if (result > 0) { return 1; }
            //////////////
            return 0;
        }
        #endregion

        #region PUT
        public async Task<ActionResult<int>> Put(DTOUsuarioP pDTOU, int pID)
        {
            var exist = _rusuario.GetID(pID);
            if (exist == null) { return 0; }
            /////////////////////////////////////

            var users    = await exist;
                users    = _mapper.Map(pDTOU,users);

            var action = _rusuario.Put(users);
            var result = await action;

            if (result > 0) { return 1; }
            //////////////
            return 0;
        }

        #endregion

        #region DELETE  
        public async Task<ActionResult<int>> Delete(int pID)
        {
            var exist = _rusuario.GetID(pID);
            if (exist == null) { return 0; }
            /////////////////////////////////////

            var users  = await exist;
            var action = _rusuario.Delete(users);
            var result = await action;

            if (result > 0) { return 1; }
            //////////////
            return 0;
        }

        #endregion

        //////////////////////////    
    }
}
