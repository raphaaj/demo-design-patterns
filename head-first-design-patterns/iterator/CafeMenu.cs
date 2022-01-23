using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public class CafeMenu : IMenu
    {
        private readonly Hashtable menuItems;

        public CafeMenu()
        {
            menuItems = new Hashtable();

            AddItem("Veggie Burger and Air Fries", "Veggie Burger on a whole wheat bun, lettuce, tomato and fries", true, 3.99);
            AddItem("Soup of the day", "A cup of soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa and guacamole", true, 4.29);
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, isVegetarian, price);
            menuItems.Add(item.Name, item);
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new CafeMenuIterator(menuItems);
        }
    }
}
