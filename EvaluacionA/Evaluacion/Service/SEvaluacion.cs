using EvaluacionA.Evaluacion.Interface;
using EvaluacionA.EvaluacionStrategy;
using EvaluacionA.EvaluacionStrategy.Strategy;
using EvaluacionA.Objects;
using Eventos.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using RestSharp;
using System.Data;
using System.Security.AccessControl;
using System.Text.Json.Serialization;
using Usuarios.Usuario.Interface;
using Usuarios.Usuario.Service;

namespace EvaluacionA.Evaluacion.Service
{
    public class SEvaluacion : IEvaluacion
    {
        
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

            if (pDateS == default(DateTime)){
                pDateS = DateTime.Now;
            }

            DateTime DateF = pDateS.AddDays(-10);
            
            var Uclient  = new RestClient().AddDefaultHeader(KnownHeaders.Accept,"");
            
            //// Conseguir Usuario y Razon Social ///
            var rusuario = new RestRequest("https://localhost:7167/api/usuario/" + pID, Method.Get);
                rusuario.RequestFormat = DataFormat.Json;
            
            var respuestaU = Uclient.Execute(rusuario);
            if (respuestaU.Content == null) { throw new Exception("usuario no encontrado"); }
           
            #pragma warning disable CS8600 
            dynamic jsonuser =  JsonConvert.DeserializeObject(respuestaU.Content);
            #pragma warning disable CS8602 
            var rs = Int32.Parse(jsonuser["razonSocialID"].ToString() ?? 0);
            
            ////// Conseguir Dates /////
            var rdates  = new RestRequest("https://localhost:7203/api/evento/dates/" + pID, Method.Get);
                rdates.AddParameter("date", pDateS.Date.ToString("o"));
                rdates.RequestFormat = DataFormat.Json;

            var respuestaD = Uclient.Execute(rdates);
            if (respuestaD.Content == null) { throw new Exception("no existen eventos del Usuario. ");}

            List<OEvento> DatesList = JsonConvert.DeserializeObject<List<OEvento>>(respuestaD.Content ?? "{}");
            
            //// Accion Evaluacion//
            var contex = new ContextEV();
            var result = 0;
            switch (rs){
                case 1:
                    contex.SetStrategy(new STEvaluacionRS1());
                    break;
                case 2:
                    contex.SetStrategy(new STEvaluacionRS2());
                    break;
                case 3:
                    contex.SetStrategy(new STEvaluacionRS3());
                    break;
            }

            result = contex.Ejecta(rs, DatesList);
            return result;

            throw new NotImplementedException();
        }
    }
}
