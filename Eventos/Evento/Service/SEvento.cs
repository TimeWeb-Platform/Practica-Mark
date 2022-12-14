using AutoMapper;
using Eventos.Domain;
using Eventos.DTO;
using Eventos.Evento.Interface;
using Eventos.Evento.Repostorie;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Eventos.Evento.Service
{
    public class SEvento : IEvento
    {
        private readonly REvento _evento;
        private readonly IMapper _mapper;

        public SEvento(REvento evento, IMapper mapper)
        {
            _evento = evento;
            _mapper = mapper;
        }

        #region GET
        public async Task<ActionResult<List<DTOEvento>>> GetAll()
        {
            var eventos = await _evento.GetAll();
            var result  = _mapper.Map<List<DTOEvento>>(eventos);
            return result;
        }

        public async Task<ActionResult<List<DTOEvento>>> GETDates(int pID, DateTime pDateS)
        {
            if (pDateS.ToString() == null ) { pDateS = DateTime.Now; }
            var DateF = pDateS.AddDays(-10);
            
            var eventos = await _evento.GetDates(pID, pDateS, DateF);
            var result  = _mapper.Map<List<DTOEvento>>(eventos);
            return result;
        }

        public async Task<ActionResult<DTOEvento>> GetID(int pID)
        {
            var eventos = await _evento.GetID(pID);
            var result  = _mapper.Map<DTOEvento>(eventos);
            return result;

        }
        #endregion
        
        #region POST
        public async Task<ActionResult<int>> Post(DTOEventoC pDTOE){

            var eventos = _mapper.Map<OEvento>(pDTOE);

            //// validar usuario Existe ////
            var Uclient  = new RestClient().AddDefaultHeader(KnownHeaders.Accept, "");
            var rusuario = new RestRequest("https://localhost:7167/api/usuario/" + eventos.UsuarioID, Method.Get);
                rusuario.RequestFormat = DataFormat.Json;

            var respuestaU  = Uclient.Execute(rusuario);
            var userstring  = respuestaU.Content;
            if (userstring == null || userstring.ToString() == "") { throw new Exception("usuario no encontrado"); }

            // accion POST
            var action = _evento.Post(eventos);
            var result = await action;

            if (result > 0) { return 1; }
            ////////////////////////////
            return 0;
        }
        #endregion

//////////////////////////////////////////
    }
}
