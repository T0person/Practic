using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Items
{
    public class Light
    {
        // Свет может быть только гореть/не гореть
        public void On()
        {
            Console.WriteLine("Свет включен");
        }
        public void Off()
        {
            Console.WriteLine("Свет выключен");
        }
    }
}
