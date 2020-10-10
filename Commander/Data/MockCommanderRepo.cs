using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommmand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{ Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Klette & Pan" },
                new Command{ Id = 1, HowTo = "Cut bread", Line = "Get a Knife", Platform = "Knife & Chopping board" },
                new Command{ Id = 2, HowTo = "Make a Cup of Tea", Line = "Place teabag in a Cup", Platform = "Klette & Cup" },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Klette & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            //Nothing
        }
    }
}
