using GumballMachine.Abstract;
using GumballMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine.States
{
    // Шар продан

    // Раскоменти если хочешь использовать интерфейс
    class SoldState : State
    {
        GumballMachine _gumballMachine;

        // Сcылка на автомат, которая просто сохраняется в переменной экземпляра
        public SoldState(GumballMachine _gumballMachine)
        {
            this._gumballMachine = _gumballMachine;
        }
        public override void Dispense()
        {
            _gumballMachine.ReleaseBall();
            //if (_gumballMachine.Count > 0)
            //    _gumballMachine.State = _gumballMachine.No_quarter;
            //else
            //{
            //    Console.WriteLine("сорян, больше нет шаров");
            //    _gumballMachine.State = _gumballMachine.Sold_out;
            //}
            //Console.WriteLine("шарик вылетает");
            //Console.WriteLine();
        }

        //public void EjectQuarter()
        //{
        //    Console.WriteLine("Автомат не вернет, шарик уже куплен!!");
        //}

        //public void InsertQuarter()
        //{
        //    Console.WriteLine("Шарик куплен, погоди чутка ПЕРЕЗАРЯДКА!");
        //}

        //public void TurnCrank()
        //{
        //    Console.WriteLine("Все распродано");
        //}
    }
}
