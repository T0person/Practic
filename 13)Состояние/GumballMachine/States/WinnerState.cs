using GumballMachine.Abstract;
using GumballMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine.States
{
    // Когда повезло (выпало два шара)

    // Раскоменти если хочешь использовать интерфейс

    // Если нужна логика перехода, то раскоменти и убери в Gumball....
    class WinnerState : State
    {
        GumballMachine _gumballMachine;

        // Сcылка на автомат, которая просто сохраняется в переменной экземпляра
        public WinnerState(GumballMachine _gumballMachine)
        {
            this._gumballMachine = _gumballMachine;
        }
        public override void Dispense()
        {
            Console.WriteLine("Поздравляю, Ты WINNER!!! Получай дабл");
            _gumballMachine.ReleaseBall();
            //if (_gumballMachine.Count == 0)
            //    _gumballMachine.State = _gumballMachine.Sold_out;
            //else
            //{
            //    _gumballMachine.ReleaseBall();
            //    if (_gumballMachine.Count > 0)
            //        _gumballMachine.State = _gumballMachine.No_quarter;
            //    else
            //    {
            //        Console.WriteLine("Нет шароV");
            //        _gumballMachine.State = _gumballMachine.Sold_out;
            //    }

            //}
        }

        //public void EjectQuarter()
        //{
        //    Console.WriteLine("Ошибка EjectQuarter");
        //}

        //public void InsertQuarter()
        //{
        //    Console.WriteLine("Ошибка InsertQuarter");
        //}

        //public void TurnCrank()
        //{
        //    Console.WriteLine("Ошибка TurnCrank");
        //}
    }
}
