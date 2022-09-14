using AutoMapper;
using Eventos.Domain;
using Eventos.DTO;

namespace Usuarios.MapperProfiles
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<OEvento, DTOEvento >().ReverseMap();
            CreateMap<OEvento, DTOEventoC>().ReverseMap();
            
        }
/////////////////////////////////////////
    }
}
