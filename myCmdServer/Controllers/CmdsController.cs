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
        //[HttpGet("{id}")] // appends {id} to the controller's Uri string. This allow to handle Uri = /api/Cmds/{id}
        [HttpGet("{id}", Name = "GetCommandById")] // Name attribute used to redirect purpose. TODO: find more
        public ActionResult<CmdReadDto> GetCommandByID(int id)
        {
            var cmd = _repo.GetCommandByID(id);
            if (cmd == null)
                return NotFound();

            CmdReadDto cmdDto = _mapper.Map<CmdReadDto>(cmd);
            return Ok(cmdDto);
        }

        /// <summary>
        /// API Endpoint for HTTP Post - create new cmd.
        /// </summary>
        /// <param name="cmdCreateDto"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<CmdCreateDto> CreateCommand(CmdCreateDto cmdCreateDto) // Find how Dto object is created from request body
        {
            var cmd = _mapper.Map<Command>(cmdCreateDto);
            _repo.CreateCommand(cmd);
            _repo.SaveChanges();

            // REST Spec for POST : return Status Code 201 with the URI where to find the resource created.

            var cmdReadDto = _mapper.Map<CmdReadDto>(cmd);
            return CreatedAtRoute(nameof(GetCommandByID), new { Id = cmd.Id }, cmdReadDto); // Find more about this API
        }

        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CmdUpdateDto cmdUpdateDto)
        {
            Command cmdDB = _repo.GetCommandByID(id);
            _mapper.Map(cmdUpdateDto, cmdDB);

            _repo.UpdateCommand(cmdDB); // SQL might not have any implementation. But, we are coding to interface. Hence requires call...
            _repo.SaveChanges();

            return NoContent(); // 204 No COntent
        }
    }
}