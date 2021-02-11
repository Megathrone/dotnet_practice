using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MS_web.Data;
using MS_web.Models;

namespace MS_web.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandRepo _repo;
        public CommandsController(ICommandRepo repo)
        {
            _repo = repo;
        }

        //private readonly MockCommandRepo _repo = new MockCommandRepo();
        
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commands = _repo.GetAllCommands();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id) 
        {
            var command = _repo.GetCommandByID(id);
            return Ok(command);
        }
    }
}