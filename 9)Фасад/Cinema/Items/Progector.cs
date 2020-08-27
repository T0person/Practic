using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Items
{
    public class Progector
    {
        public void On()
        {
            Console.WriteLine("Прожектор влючается");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Широко-экранный режим прожектора");
        }

        public void Off()
        {
            Console.WriteLine("Прожектор выключается");
        }
    }
}
