using GumballMachine.Abstract;
using GumballMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine.States
{
    // Нет шаров

    // Раскоменти если хочешь использовать интерфейс
    class SoldOutState : State
    {
        GumballMachine _gumballMachine;

        // Сcылка на автомат, которая просто сохраняется в переменной экземпляра
        public SoldOutState(GumballMachine _gumballMachine)
        {
            this._gumballMachine = _gumballMachine;
        }

        //public void Dispense()
        //{
        //    Console.WriteLine("конфета не выдается");
        //}

        //public void EjectQuarter()
        //{
        //    Console.WriteLine("Автомат не вернет монетку, все распродано!!");
        //}

        //public void InsertQuarter()
        //{
        //    Console.WriteLine("В автомате не осталось шариков!");
        //}

        //public void TurnCrank()
        //{
        //    Console.WriteLine("Нет шаров");
        //}
    }
}
