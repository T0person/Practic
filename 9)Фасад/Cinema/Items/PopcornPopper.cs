using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Items
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Попкорн включается");
        }

        public void Off()
        {
            Console.WriteLine("Попкорн выключается");
        }

        public void Pop()
        {
            Console.WriteLine("Попкорн готовится");
        }
    }
}
