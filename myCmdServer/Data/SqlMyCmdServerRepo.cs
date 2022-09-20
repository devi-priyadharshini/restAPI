using System.Collections.Generic;
using System.Linq;
using myCmdServer.Models;

namespace myCmdServer.Data
{

    public class SqlMyCmdServerRepo : IMyCmdServerRepo
    {

        CmdDbContext _context;

        public SqlMyCmdServerRepo(CmdDbContext dbContext)
        {
            _context = dbContext;

        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(cmd => cmd.Id == id);
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd != null)
                _context.Commands.Add(cmd);
        }

        /// <summary>
        /// All the dbContext changes are reflected in DB only when we call SaveChanges
        /// </summary>
        /// <returns></returns> 
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}