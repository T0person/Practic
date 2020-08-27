using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands
{
    class MacroCommand : ICommand
    {
        ICommand[] _commands;

        public MacroCommand(ICommand[] _commands)
        {
            this._commands = _commands;
        }

        public void execute()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].execute();
            }
        }

        public void undo()
        {
            for (int i = 0; i < _commands.Length; i++)
            {
                _commands[i].undo();
            }
        }
    }
}
