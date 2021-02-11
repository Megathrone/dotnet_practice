using System.Collections.Generic;
using MS_web.Models;

namespace MS_web.Data
{
    public class MockCommandRepo : ICommandRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{id=0, HowTo="nmsl0", Line="xixi0", Platform="MacOS"},
                new Command{id=1, HowTo="nmsl1", Line="xixi1", Platform="MacOS"},
                new Command{id=2, HowTo="nmsl2", Line="xixi2", Platform="MacOS"}
            };

            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command { id = 0, HowTo = "nmsl", Line = "xixi", Platform = "MacOS" };
        }
    }
}