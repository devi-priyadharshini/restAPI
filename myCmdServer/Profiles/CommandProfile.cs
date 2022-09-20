using AutoMapper;
using myCmdServer.Models;
using myCmdServer.Dtos;


namespace myCmdServer.Profiles
{

    public class CmdsProfile : Profile
    {
        public CmdsProfile()
        {
            // Maps Command object to its equivalent CmdReadDto
            // HTTP GET
            CreateMap<Command, CmdReadDto>();

            // Maps CmdCreateDto to Command object
            // HTTP Post
            CreateMap<CmdCreateDto, Command>();

        }
    }
}