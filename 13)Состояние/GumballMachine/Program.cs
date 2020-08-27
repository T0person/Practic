using System;

namespace GumballMachine
{
    // 10 глава
    // 13 паттерн
    // Паттерн Состояния
    class Program
    {
        // Говорится что каждое состояние закрыто для изменения, однако сам автомат открыт для расширения, но как оно закрыто, если везде public?!
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            Console.WriteLine($"Состояние автомата: {gumballMachine.State}");

            // Бросаем монету
            gumballMachine.InsertQuarter();

            // Дергаем за рычаг [требуем шарик] (выдает шарик)
            gumballMachine.TurnCrank();

            Console.WriteLine($"Состояние автомата: {gumballMachine.State}");

            // Бросаем монету
            gumballMachine.InsertQuarter();

            // Забираем монету
            gumballMachine.EjectQuarter();

            // Дергаем за рычаг [требуем шарик] (не выдает шарик)
            gumballMachine.TurnCrank();

            Console.WriteLine($"Состояние автомата: {gumballMachine.State}");

            // Бросаем монету
            gumballMachine.InsertQuarter();

            // Бросаем монету
            gumballMachine.InsertQuarter();

            // Дергаем за рычаг [требуем шарик] (выдает шарик)
            gumballMachine.TurnCrank();

            // Бросаем монету
            gumballMachine.InsertQuarter();

            // Дергаем за рычаг [требуем шарик] (выдает шарик)
            gumballMachine.TurnCrank();

            // Бросаем монету
            gumballMachine.InsertQuarter();

            // Дергаем за рычаг [требуем шарик] (выдает шарик)
            gumballMachine.TurnCrank();

            Console.WriteLine($"Состояние автомата: {gumballMachine.State}");
        }
    }
}
