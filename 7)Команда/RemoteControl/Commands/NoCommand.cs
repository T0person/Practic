using RemoteControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Commands
{
    public class NoCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Нет команды!");
        }

        public void undo()
        {
            Console.WriteLine("Нет команды!");
        }
    }
}
