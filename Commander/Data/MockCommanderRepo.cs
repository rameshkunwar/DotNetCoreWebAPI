using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo 
    {
        List<Command> commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "boil water", Platform = "kettle" },
                new Command { Id = 1, HowTo = "make kheer", Line = "making kheer", Platform = "Milk" },
                new Command { Id = 2, HowTo = "Sekwa", Line = "make sekwa", Platform = "jheer" },
                new Command { Id = 3, HowTo = "Kurauni", Line = "make kurauni", Platform = "bit sausepan" }
        };

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {            
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return commands.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}