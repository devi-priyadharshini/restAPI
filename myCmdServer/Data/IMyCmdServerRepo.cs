using System.Collections.Generic;
using myCmdServer.Models;

namespace myCmdServer.Data
{
    /// <summary>
    /// Repository patter - Interface that encloses operations that a repo should/can provide. 
    /// </summary>

    public interface IMyCmdServerRepo
    {
        IEnumerable<Command> GetCommands();

        Command GetCommandByID(int id);
    }
}