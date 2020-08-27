using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.LightCommands
{
    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.Off();
        }

        public void undo()
        {
            light.On();
        }
    }
}
