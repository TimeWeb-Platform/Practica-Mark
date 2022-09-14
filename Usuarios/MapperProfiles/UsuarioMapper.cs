using AutoMapper;
using Usuarios.Domain;
using Usuarios.DTO;

namespace Usuarios.MapperProfiles
{
    public class UsuarioMapper : Profile
    {
        public UsuarioMapper()
        {
            CreateMap<OUsuario, DTOUsuario >().ReverseMap();
            CreateMap<OUsuario, DTOUsuarioC>().ReverseMap();
            CreateMap<OUsuario, DTOUsuarioP>().ReverseMap();

        }
/////////////////////////////////////////
    }
}
