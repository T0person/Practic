using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Items
{
    public class Screen
    {
        public void Down()
        {
            Console.WriteLine("Экран опускается");
        }
        public void Up()
        {
            Console.WriteLine("Экран поднимается");
        }
    }
}
