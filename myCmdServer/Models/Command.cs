
/// Models - internal representation o f data. 

namespace myCmdServer.Models{

    /// class Command represents a cmd - cmd including for all platforms and apps.
    // Ex DOS Cmd Prompt app Command - "cd" command to change directory
    public class Command{

        // Unique Id given to identify cmd 
        public int Id { get; set; }

        // Purpose/Use of this command
        public string Use { get; set; }

        // Command string
        public string cmdString { get; set; }

        // platform where this cmd is meant for
        public string Platform { get; set; }
    }
}