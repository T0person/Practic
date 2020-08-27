using RemoteControl.Interfaces;
using RemoteControl.Items;
using System;

namespace RemoteControl.Commands.CeilingFanCommands
{
    class CeilingFanHighCommand : ICommand
    {
        private CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }
        public void execute()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.High();
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
                case 2:
                    _ceilingFan.Medium();
                    break;
            }
        }
    }
}
