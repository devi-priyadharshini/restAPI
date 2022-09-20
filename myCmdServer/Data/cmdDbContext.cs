using Microsoft.EntityFrameworkCore;
using myCmdServer.Models;

namespace myCmdServer.Data
{

    /// DbContext - represents a session for database operation.
    /// Session is established when application connects with database
    public class CmdDbContext : DbContext
    {
        public CmdDbContext(DbContextOptions<CmdDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Represents table or view. 
        /// </summary>
        public DbSet<Command> Commands { get; set; }
    }
}