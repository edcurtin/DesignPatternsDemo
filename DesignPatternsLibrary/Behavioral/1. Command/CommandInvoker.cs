using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibrary.Behavioral._1._Command
{
    public class CommandInvoker
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void StoreCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }

            _commands.Clear(); // Clear commands after execution if needed
        }
    }
}
