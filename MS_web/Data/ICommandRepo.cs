
using System.Collections.Generic;
using MS_web.Models;

namespace MS_web.Data
{
    public interface ICommandRepo
    {
        IEnumerable<Command> GetAllCommands();
        
        Command GetCommandByID(int id);
    }
}