using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.StereoCommands
{
    class StereoOffCommand : ICommand
    {
        Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.Off();
        }

        public void undo()
        {
            stereo.On();
        }
    }
}
