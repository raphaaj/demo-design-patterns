using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinnerMenu = new Menu("DINNER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFÉ MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinnerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem("K&B´s Pancake Breakfast", "Pancakes with scrambled eggs and toast", true, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59));

            dinnerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinnerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinnerMenu.Add(new MenuItem("Soup of the day", "Soup of the day with a side of potato salad", false, 3.29));
            dinnerMenu.Add(new MenuItem("Hotdog", "A hot dogm with saurkraut, relish, onions, topped with cheese", false, 3.29));
            dinnerMenu.Add(dessertMenu);

            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie Burger on a whole wheat bun, lettuce, tomato and fries", true, 3.99));
            cafeMenu.Add(new MenuItem("Soup of the day", "A cup of soup of the day, with a side salad", false, 3.69));
            cafeMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa and guacamole", true, 4.29));

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla ice cream", true, 1.59));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();
        }
    }
}
