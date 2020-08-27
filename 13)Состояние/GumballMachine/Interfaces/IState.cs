using System;
using System.Collections.Generic;
using System.Text;

namespace GumballMachine.Interfaces
{
    public interface IState : IServiceProvider
    {
        // Когда в автомат бросают монетку
        void InsertQuarter();

        // Когда покупатель возвращает монетку
        void EjectQuarter();

        // Покупатель пытается дернуть за рычаг (ЗАЧЕМ?! Это все было уже написано!)
        void TurnCrank();

        // Тут выдается шарик
        void Dispense();
    }
}
