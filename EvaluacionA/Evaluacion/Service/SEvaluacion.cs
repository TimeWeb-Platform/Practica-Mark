using EvaluacionA.Evaluacion.Interface;
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

            if (pDateS == default(DateTime))
            {
                pDateS = DateTime.Now;
            }
            DateTime DateF = pDateS.AddDays(-10);
            
            var Uclient  = new RestClient().AddDefaultHeader(KnownHeaders.Accept,"");
           
            var rusuario = new RestRequest("https://localhost:7167/api/usuario/" + pID, Method.Get);
                rusuario.RequestFormat = DataFormat.Json;
            
            var rdates = new RestRequest("https://localhost:7203/api/evento/dates"+pID, Method.Get);
                rdates.AddBody(pDateS);
                rdates.RequestFormat = DataFormat.Json;

            var respuestaU = Uclient.Execute(rusuario);

            if (respuestaU.Content == null) { return 0; }
            
            #pragma warning disable CS8600 
            dynamic jsonuser =  JsonConvert.DeserializeObject(respuestaU.Content);
            #pragma warning disable CS8602 
            var rs = Int32.Parse(jsonuser["razonSocialID"].ToString() ?? 0);

            var respuestaD = Uclient.Execute(rdates);
            List<OEvento> DatesList = JsonConvert.DeserializeObject<List<OEvento>>(respuestaD.Content ?? "");
            var diasapagar = 0;
            var eventoval = pDateS;
            var totalasistencias = 0;
            switch (rs)
            {
                case 1:
                    
                    foreach(OEvento even in DatesList){
                        if (even.FechaAlta == eventoval  ) {
                            totalasistencias++;
                        }
                        eventoval.AddDays(+1);

                    }

                    return totalasistencias;
                case 2:
                    return -1;
                case 3:
                    var eventofinval = eventoval.AddHours(8);
                    for (int valor = 0; valor <= DatesList.Count; valor++)
                    {
                        if (DatesList[valor].FechaAlta == eventoval && DatesList[valor + 1].FechaAlta == eventofinval)
                        {
                            totalasistencias++;
                        }
                        eventoval.AddDays(+1);
                        eventofinval.AddDays(+1); 
                    }
                    return totalasistencias ;
            }
            return 0;

            throw new NotImplementedException();
        }
    }
}
