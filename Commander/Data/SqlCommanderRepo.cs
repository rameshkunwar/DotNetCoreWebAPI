﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext commanderContext)
        {
            _context = commanderContext;          
            _context.Database.EnsureCreated();
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException(nameof(cmd));
            _context.Commands.Add(cmd);
        }

        public void DeleteCommand(Command command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));
            
            _context.Commands.Remove(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
          return  (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command command)
        {
           //do Nothing
        }
    }
}
