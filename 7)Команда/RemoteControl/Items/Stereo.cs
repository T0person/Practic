using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl.Items
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Включился");
        }
        public void Off()
        {
            Console.WriteLine("Выключился");
        }
        public void setCd()
        {
            Console.WriteLine("CD");
        }
        public void setDvd()
        {
            Console.WriteLine("DVD");
        }
        public void setRadio()
        {
            Console.WriteLine("Радио");
        }
        public void setVolume(int volume)
        {
            Console.WriteLine(volume);
        }
    }
}
