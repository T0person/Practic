using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.GarageCommands
{
    class GarageDoorCloseCommand : ICommand
    {
        Garage garageDoor;
        public GarageDoorCloseCommand(Garage garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void execute()
        {
            garageDoor.Down();
        }

        public void undo()
        {
            garageDoor.Up();
        }
    }
}
