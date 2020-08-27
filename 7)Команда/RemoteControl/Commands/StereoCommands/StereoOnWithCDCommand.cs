using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.StereoCommands
{
    class StereoOnWithCDCommand : ICommand
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void execute()
        {
            stereo.On();
            stereo.setCd();
            stereo.setVolume(11);
        }

        public void undo()
        {
            stereo.Off();
        }
    }
}
