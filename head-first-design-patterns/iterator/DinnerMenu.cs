using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public class DinnerMenu : IMenu
    {
        static readonly int MAX_ITEMS = 6;

        private readonly MenuItem[] menuItems;
        private int numberOfItems { get; set; }
        public int NumberOfItems { get { return numberOfItems; } }
        

        public DinnerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dogm with saurkraut, relish, onions, topped with cheese", false, 3.29);
        }

        private void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, isVegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full!! Can1t add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = item;
                numberOfItems += 1;
            }
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new DinnerMenuIterator(menuItems);
        }

        public override string ToString()
        {
            string str = "";

            foreach (var item in menuItems)
            {
                if (item != null)
                {
                    str += item.Name + "\n";
                }
            }

            return str;
        }
    }
}
