using AutoMapper;
using myCmdServer.Models;
using myCmdServer.Dtos;


namespace myCmdServer.Profiles
{

    public class CmdsProfile : Profile
    {
        public CmdsProfile()
        {
            CreateMap<Command, CmdReadDto>();
        }
    }
}