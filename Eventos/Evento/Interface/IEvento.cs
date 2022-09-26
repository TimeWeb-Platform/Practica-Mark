using Eventos.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.Evento.Interface
{
    public interface IEvento
    {
        Task<ActionResult<List<DTOEvento>>> GetAll();
        Task<ActionResult<DTOEvento>> GetID(int pID);
        Task<ActionResult<int>> Post(DTOEventoC pDTOU);
        Task<ActionResult<List<DTOEvento>>>GETDates(int pID,DateTime pDateS);
        
    }
}
