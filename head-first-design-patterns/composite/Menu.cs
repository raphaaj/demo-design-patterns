using System;
using System.Collections.Generic;
using System.Text;

namespace composite
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> MenuComponents = new List<MenuComponent>();
        private string Name;
        private string Description;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            MenuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            MenuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return MenuComponents[i];
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override void Print()
        {
            Console.WriteLine($"\n{GetName()}, {GetDescription()}");
            Console.WriteLine("-----------------------");

            IEnumerator<MenuComponent> iterator = MenuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }
        }
    }
}
