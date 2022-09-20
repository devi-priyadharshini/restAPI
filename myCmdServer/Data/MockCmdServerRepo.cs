using System.Collections.Generic;
using myCmdServer.Models;

namespace myCmdServer.Data
{

    public class MockMyCmdServerRepo
    {
        private Command mockCommand = new Command()
        {
            Id = 0,
            Use = "Change directory",
            cmdString = "cd"
        };

        public IEnumerable<Command> GetCommands()
        {
            return new List<Command>() {
                 new Command() {Id = 0,Use = "change directory", cmdString = "cd"},
                 new Command() {Id = 1,Use = "change directory", cmdString = "mk"},
                 new Command() {Id = 2,Use = "change directory", cmdString = "del"}
             };
        }

        public Command GetCommandByID(int id)
        {
            return mockCommand;
        }
    }
}