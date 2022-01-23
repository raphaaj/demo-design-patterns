using System;
using System.Collections.Generic;

namespace iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            DinnerMenu dinnerMenu = new DinnerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            CafeMenu cafeMenu = new CafeMenu();

            List<IMenu> menus = new List<IMenu>() { dinnerMenu, pancakeHouseMenu, cafeMenu };

            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }
    }
}
