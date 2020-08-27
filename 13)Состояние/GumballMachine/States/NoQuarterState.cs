using GumballMachine.Abstract;
using GumballMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine.States
{
    // Монета не вставлена

    // Раскоменти если хочешь использовать интерфейс
    class NoQuarterState : State
    {
        GumballMachine _gumballMachine;

        // Сcылка на автомат, которая просто сохраняется в переменной экземпляра
        public NoQuarterState(GumballMachine _gumballMachine)
        {
            this._gumballMachine = _gumballMachine;
        }
        //public void Dispense()
        //{
        //    Console.WriteLine("слышь, заплати сначала");
        //}

        //public void EjectQuarter()
        //{
        //    Console.WriteLine("Автомат не может вернуть, так как нет монетки!!");
        //}

        public override void InsertQuarter()
        {
            Console.WriteLine("Вы вставили монетку в автомат!");
            //_gumballMachine.State = _gumballMachine.Has_quater;
        }

        //public void TurnCrank()
        //{
        //    Console.WriteLine("Сначала киньте монету");
        //}
    }
}
