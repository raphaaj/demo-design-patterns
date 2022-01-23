using System;
using System.Collections.Generic;
using System.Text;

namespace composite
{
    public class Waitress
    {
        MenuComponent AllMenus;

        public Waitress(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }

        public void PrintMenu()
        {
            AllMenus.Print();
        }
    }
}
