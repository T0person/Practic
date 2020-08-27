using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Items
{
    class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        private string location;
        private int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine($"{speed} скорость вентилятора");
        }

        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine($"{speed} скорость вентилятора");
        }
        public void Low()
        {
            speed = LOW;
            Console.WriteLine($"{speed} скорость вентилятора");
        }
        public void Off()
        {
            speed = OFF;
            Console.WriteLine($"{speed} скорость вентилятора");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}
