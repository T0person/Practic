using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands.CeilingFanCommands
{
    class CeilingFanMediumCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Medium();
        }

        public void undo()
        {
            switch (_prevSpeed)
            {
                case 0:
                    _ceilingFan.Off();
                    break;
                case 1:
                    _ceilingFan.Low();
                    break;
                case 3:
                    _ceilingFan.High();
                    break;
            }
        }
    }
}
