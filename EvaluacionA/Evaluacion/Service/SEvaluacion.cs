using EvaluacionA.Evaluacion.Interface;
using Eventos.Controllers;
using Microsoft.AspNetCore.Mvc;
using Usuarios.Usuario.Interface;
using Usuarios.Usuario.Service;

namespace EvaluacionA.Evaluacion.Service
{
    public class SEvaluacion : IEvaluacion
    {
        private readonly IUsuario usuario;

        

        public async Task<ActionResult<int>> vacio()
        {

            var action = 0;
            var result = action;

            if (result > 0) { return 1; }
            ////////////////////////////
            return 0;
        }

        public async Task<ActionResult<int>> asistencia(int pID, DateTime pDateS)
        {

            if (pDateS == default(DateTime))
            {
                pDateS = DateTime.Now;
            }
            DateTime DateF = pDateS.AddDays(-10);

            // var usuario  = await _usuario.GetID(pID);
            var rs = 1;// usuario.RazonSocialid
            //  if (usuario == null) { throw new Exception(); }
            var dates = default(DateTime); // LISTevento.GetAll();    

            switch (rs)
            {
                case 1:
                    

                break;
                case 2:
                break;
                case 3:
                break;
            }
            return 0;

            throw new NotImplementedException();
        }
    }
}
