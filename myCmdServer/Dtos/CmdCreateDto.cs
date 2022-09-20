using System.ComponentModel.DataAnnotations;

namespace myCmdServer.Dtos
{
    public class CmdCreateDto
    {
        /// <summary>
        /// Without required attribute:
        /// If user missed to give this value in request, then
        /// internal server error will be thrown while updating 
        /// DB, since in DB this column is marked required.
        /// 
        /// Making this DTO object also required, will 
        /// let user know the request should be made along with this
        /// cmdString by throwing Bad Request error. 
        /// </summary>
        [Required]
        public string CmdString { get; set; }

        [Required]
        public string Use { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}