using Linker.Items;
using System;

namespace Linker
{
    // 9 глава
    // 12 паттерн
    // Компоновщик
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем все объекты меню
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINERE MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "dessert");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            dinerMenu.Add(new MenuItem("Pasta", "Spagerri with Marinara Sauce", true, 3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple Pie with a flakey crust", true, 1.59));

            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();

            Console.WriteLine("ПО НОВОЙ ВСЕ!!!!\n\n\n\n");
            waitress.PrintVegetarianMenu();
        }
    }
}
