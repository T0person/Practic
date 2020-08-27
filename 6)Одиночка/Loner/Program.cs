using System;

namespace Loner
{
    // 5 глава
    // 6 паттерн
    // Одиночка
    class Program
    {
        static void Main(string[] args)
        {
            // Создается класс
            Singleton.GetInstance();

            // Не создается!
            Singleton.GetInstance();
        }
    }
}
