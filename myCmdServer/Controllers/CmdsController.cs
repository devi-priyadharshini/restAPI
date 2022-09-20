using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using myCmdServer.Models;
using myCmdServer.Data;
using myCmdServer.Dtos;

using AutoMapper;

namespace myCmdServer.Controllers
{
    // api/Cmds
    [Route("api/[controller]")] //Controller level Route. [controller] is replaced with class name (without Cotroller)
    [ApiController] // adds default behaviour to the controller
    public class CmdsController : ControllerBase
    {
        #region notes...

        // 1) 
        // URI "api/Cmds/" is mapped to this conrtoller.
        // REST Verb in the HTTP Request is mapped to the action/method in controller decorated with rest verb (or)
        // Note: Same URI's can do different operation, identified by the REST Verb.
        // Ex: HTTP req 1: URL : "api/Cmds/" ,  REST Verb : POST => triggers Create action
        // Ex: HTTP req 2: URL : "api/Cmds/" ,  REST Verb : PUT  => triggers Update action.

        // Ex: HTTP req 1: URL : "api/Cmds/{id}" ,  REST Verb : POST => triggers Create action
        // Ex: HTTP req 2: URL : "api/Cmds/{id}" ,  REST Verb : PUT  => triggers Update action.
        // Ex: HTTP req 2: URL : "api/Cmds/{id}" ,  REST Verb : GET => triggers read actions
        // etc...

        // 2) 2 methods cannot have the same HTTPGET. This will not tell to which HTTPGET method the route should map to for 
        // GET request.

        // 3) Why action returns ActionResult not the object directly?
        #endregion

        IMyCmdServerRepo _repo;
        IMapper _mapper;

        public CmdsController(IMyCmdServerRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET /api/cmds
        [HttpGet] // HTTPGET tells that this method should response to controllers api's get request
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            return Ok(_mapper.Map<IEnumerable<CmdReadDto>>(_repo.GetCommands()));
        }

        // GET /api/cmds/{id}
        [HttpGet("{id}")] // appends {id} to the controller's Uri string. This allow to handle Uri = /api/Cmds/{id}
        public ActionResult<CmdReadDto> GetCommandByID(int id)
        {
            var cmd = _repo.GetCommandByID(id);
            if (cmd == null)
                return NotFound();

            CmdReadDto cmdDto = _mapper.Map<CmdReadDto>(cmd);
            return Ok(cmdDto);
        }
    }
}