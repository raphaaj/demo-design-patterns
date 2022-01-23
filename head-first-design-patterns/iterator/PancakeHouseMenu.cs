using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("K&B´s Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59);
        }

        private void AddItem(string name, string description, bool isVegeterian, double price)
        {
            MenuItem item = new MenuItem(name, description, isVegeterian, price);
            menuItems.Add(item);
        }

        public IIterator<MenuItem> CreateIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }

        public override string ToString()
        {
            return menuItems
                .Select(i => i.Name)
                .Aggregate((a, b) => $"{a}\n{b}");
        }
    }
}
