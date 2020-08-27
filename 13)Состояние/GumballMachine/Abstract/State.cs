using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine.Abstract
{
    public abstract class State 
    {
        public virtual void EjectQuarter()
        {
            Console.WriteLine("Ошибка EjectQuarter");
        }

        public virtual void InsertQuarter()
        {
            Console.WriteLine("Ошибка InsertQuarter");
        }

        public virtual void TurnCrank()
        {
            Console.WriteLine("Ошибка TurnCrank");
        }

        public virtual void Dispense()
        {
            Console.WriteLine("Ошибка Dispense");
        }
    }
}
