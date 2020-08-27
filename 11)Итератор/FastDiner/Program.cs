using FastDiner.Interfaces;
using FastDiner.Items;
using System.Collections;

namespace FastDiner
{
    // 9 глава
    // 11 паттерн
    // Итератор
    class Program
    {
        static void Main(string[] args)
        {
            //CafeMenu cafeMenu = new CafeMenu();
            //cafeMenu.hasNext();

            Menu pancakeHouseMenu = new PancakeHouseMenu();
            Menu dinerMenu = new DinerMenu();
            Menu cafeMenu = new CafeMenu();

            ArrayList menus = new ArrayList() { pancakeHouseMenu, dinerMenu, cafeMenu };
            
            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }
    }
}