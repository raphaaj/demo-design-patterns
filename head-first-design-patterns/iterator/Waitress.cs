using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public class Waitress
    {
        public readonly List<IMenu> Menus;

        public Waitress(List<IMenu> menus)
        {
            Menus = menus;
        }

        public void PrintMenu()
        {
            IEnumerator<IMenu> menuIterator = Menus.GetEnumerator();
            while (menuIterator.MoveNext())
            {
                IMenu menu = menuIterator.Current;
                PrintMenu(menu.CreateIterator());
                Console.WriteLine("\n");
            }
        }

        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem item = iterator.Next();
                Console.WriteLine($"{item.Name}, ${item.Price} -- ${item.Description}");
            }
        }
    }
}
