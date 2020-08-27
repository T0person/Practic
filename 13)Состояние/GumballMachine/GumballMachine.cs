using GumballMachine.Abstract;
using GumballMachine.Interfaces;
using GumballMachine.States;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace GumballMachine
{
    // Автомат шаров
    public class GumballMachine
    {
        private Random _randomWiner = new Random();
        public State Sold_out;
        public State No_quarter;
        public State Has_quater;
        public State Sold;
        public State Winner;

        // Текущее состояние
        public State State;

        // Кол-во шариков в автомате
        public int Count = 0;
        public GumballMachine(int Count)
        {
            // Создаем состояния
            Sold_out = new SoldOutState(this);
            No_quarter = new NoQuarterState(this);
            Has_quater = new HasQuarterState(this);
            Sold = new SoldState(this);

            this.Count = Count;

            // ждем пока кто-то бросит монетку
            if (Count > 0)
                State = No_quarter;
        }

        // Когда в автомат бросают монетку
        public void InsertQuarter()
        {
            State.InsertQuarter();

            // Для NoQuarter
            State = Has_quater;
        }

        // Когда покупатель возвращает монетку
        public void EjectQuarter()
        {
            State.EjectQuarter();

            // Для HasQuarter
            State = No_quarter;
        }

        // Покупатель пытается дернуть за рычаг (ЗАЧЕМ?! Это все было уже написано!)
        public void TurnCrank()
        {
            State.TurnCrank();

            // Для HasQuarter
            int winner = _randomWiner.Next(10);
            if (winner == 0 && Count > 1)
            {
                State = Winner;
            }
            else
                State = Sold;



            if (State != No_quarter)
                State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Шарик спускается\n");
            if (Count != 0)
                Count--;
            if (Count == 0)
                State = Sold_out;
            if (Count > 0)
                State = No_quarter;
            else
                State = Sold_out;
        }
        // Тут выдается шарик
        //public void Dispense()
        //{
        //    if (State == Sold)
        //    {
        //        Console.WriteLine("шарик вылетает");
        //        Count--;
        //        switch (Count)
        //        {
        //            case 0:
        //                Console.WriteLine("сорян, больше нет монет");
        //                State = Sold_out;
        //                break;
        //            default:
        //                State = No_quarter;
        //                break;
        //        }
        //        Console.WriteLine();
        //    }
        //    else if (State == No_quarter)
        //        Console.WriteLine("слышь, заплати сначала");
        //    else if (State == Sold_out)
        //        Console.WriteLine("конфета не выдается");
        //    else if(State == Has_quater)
        //        Console.WriteLine("конфета не выдается");
        //}
    }
}
