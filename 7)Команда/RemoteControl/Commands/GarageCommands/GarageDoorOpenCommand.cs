using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;

namespace RemoteControl.Commands.GarageCommands
{
    public class GarageDoorOpenCommand : ICommand
    {
        Garage garageDoor;

        public GarageDoorOpenCommand(Garage garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.Up();
        }

        public void undo()
        {
            garageDoor.Down();
        }
    }
}
