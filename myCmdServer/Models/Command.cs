using System.ComponentModel.DataAnnotations;


/// Models - internal representation o f data. 

namespace myCmdServer.Models
{

    /// class Command represents a cmd - cmd including for all platforms and apps.
    // Ex DOS Cmd Prompt app Command - "cd" command to change directory
    public class Command
    {

        // Unique Id given to identify cmd 
        public int Id { get; set; }

        // Purpose/Use of this command
        [Required]
        public string Use { get; set; }

        [Required]
        // Command string
        public string cmdString { get; set; }

        [Required]
        // platform where this cmd is meant for
        public string Platform { get; set; }
    }
}