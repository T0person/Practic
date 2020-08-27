using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.LightCommands
{
    public class LightOnCommand : ICommand
    {
        Light light;
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.On();
        }

        public void undo()
        {
            light.Off();
        }

    }
}
