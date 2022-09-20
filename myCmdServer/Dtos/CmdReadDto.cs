using System.ComponentModel.DataAnnotations;


/// Models - internal representation o f data. 

namespace myCmdServer.Dtos
{

    /// class Command represents a cmd - cmd including for all platforms and apps.
    // Ex DOS Cmd Prompt app Command - "cd" command to change directory
    public class CmdReadDto
    {

        // Purpose/Use of this command
        public string Use { get; set; }

        // Command string
        public string cmdString { get; set; }
    }
}