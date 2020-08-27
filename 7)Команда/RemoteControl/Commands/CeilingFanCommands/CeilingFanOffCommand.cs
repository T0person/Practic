using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.CeilingFanCommands
{
    class CeilingFanOffCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Off();
        }

        public void undo()
        {
            switch (_prevSpeed)
            {
                case 1:
                    _ceilingFan.Low();
                    break;
                case 2:
                    _ceilingFan.Medium();
                    break;
                case 3:
                    _ceilingFan.High();
                    break;
            }
        }
    }
}
