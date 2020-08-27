using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Interfaces
{
    interface ICommand
    {
        public void execute();
        public void undo();
    }
}
