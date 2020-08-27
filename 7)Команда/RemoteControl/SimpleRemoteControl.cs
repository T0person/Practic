using RemoteControl.Commands;
using RemoteControl.Commands.LightCommands;
using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    class SimpleRemoteControl
    {
        // Ячейки для хранения команды
        public ICommand[] onCommands { get; set; }
        public ICommand[] offCommands { get; set; }
        ICommand undoCommand;

        public SimpleRemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].execute();
            undoCommand = onCommands[slot];
        }
        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.undo();
        }

        public void SetCommands(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
    }
}
