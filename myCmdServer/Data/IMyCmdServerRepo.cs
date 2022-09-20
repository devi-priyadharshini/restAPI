using System.Collections.Generic;
using myCmdServer.Models;

namespace myCmdServer.Data
{
    /// <summary>
    /// Repository pattern - Interface that encloses operations that a repo should/can provide. 
    /// </summary>

    public interface IMyCmdServerRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetCommands();

        Command GetCommandByID(int id);

        void CreateCommand(Command cmd);

        void UpdateCommand(Command cmd);

        void DeleteCommand(Command cmd);
    }
}