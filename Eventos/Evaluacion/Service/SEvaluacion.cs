using Evaluacion.Evaluacion.Interface;
using Eventos.Evento.Service;
using Microsoft.AspNetCore.Mvc;
using Usuarios.Usuario.Service;

namespace Evaluacion.Evaluacion.Service
{
    public class SEvaluacion : IEvaluacion
    {
     //   private readonly SEvento  _evento;
       // private readonly SUsuario _usuario;

        //public SEvaluacion(SEvento evento, SUsuario usuario ){
         //   _evento  = evento;
          //  _usuario = usuario;
        //}
        public async Task<ActionResult<string>> EvaluarAsistencia(int pID, DateTime pDateS)
        {
            if (pDateS == default(DateTime)){
                pDateS  = DateTime.Now;
            }
            DateTime DateF = pDateS.AddDays(-10);

          //  var usuario  = await _usuario.GetID(pID);
          //  if (usuario == null) { throw new Exception(); }
            //var dates    = _evento.GETDates(pID,pDateS,DateF);    
            


            throw new NotImplementedException();
        }
    }
}





