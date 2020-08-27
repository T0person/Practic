using System;
using System.Collections.Generic;
using System.Text;

namespace Loner
{
    class Singleton
    {
        // Статическая переменная для хранения единственного экземпляра
        private static Singleton uniqueInstanse;

        // Приватный конструктор, только Singleton моэет создавать экземляры этого класса!!!
        private Singleton(){
            Console.WriteLine("Создался");
        }

        // Метод создает и возвращает экземпляр
        public static Singleton GetInstance()
        {
            if(uniqueInstanse == null)
                uniqueInstanse = new Singleton();
            return uniqueInstanse;
        }
    }
}
