using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RemoteControl.Items
{
    public class Garage
    {
        public void Up()
        {
            Console.WriteLine("Дверь поднимается");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(500);
            }
            Console.WriteLine("Дверь поднялась");
        }

        public void Down()
        {
            Console.WriteLine("Дверь опускается");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(500);
            }
            Console.WriteLine("Дверь опустилась");
        }

        public void Stop()
        {
            Console.WriteLine("Дверь остановилась");
        }

        public void LightOn()
        {
            Console.WriteLine("Свет включен");
        }
        public void LightOff()
        {
            Console.WriteLine("Свет выключен");
        }
    }
}
