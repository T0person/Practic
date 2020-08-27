using GumballMachine.Abstract;
using GumballMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GumballMachine.States
{
    // Монета вставлена

    // Раскоменти если хочешь использовать интерфейс
    public class HasQuarterState : State
    {
        private Random _randomWiner = new Random();
        GumballMachine _gumballMachine;

        // Сcылка на автомат, которая просто сохраняется в переменной экземпляра
        public HasQuarterState(GumballMachine _gumballMachine)
        {
            this._gumballMachine = _gumballMachine;
        }

        //public void Dispense()
        //{
        //    Console.WriteLine("конфета не выдается");
        //}

        public override void EjectQuarter()
        {
            Console.WriteLine("Автомат возвращает монетку!!");
            //_gumballMachine.State = _gumballMachine.No_quarter;
        }

        //public void InsertQuarter()
        //{
        //    Console.WriteLine("В автомате уже есть монетка!");
        //}

        public override void TurnCrank()
        {
            Console.WriteLine("Ты дернул");
            //int winner = _randomWiner.Next(10);
            //if (winner == 0 && _gumballMachine.Count > 1)
            //{
            //    _gumballMachine.State = _gumballMachine.Winner;
            //}
            //else
            //    _gumballMachine.State = _gumballMachine.Sold;
        }
    }
}
